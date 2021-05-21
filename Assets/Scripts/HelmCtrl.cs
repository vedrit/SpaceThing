using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class HelmCtrl : ControlBase
{
	[SerializeField] float maxMoveSpeed, turnSpeed, mouseLookDeadzone;
	[SerializeField] Dictionary<string, float> acceleration;
	[SerializeField]Vector3 shipAcceleration, lookatResetPos, thrustDelta, rotateVelocity;
	[SerializeField]Transform flagship, moveToTarget;
	[SerializeField] ShipBase flagshipStats;
	[SerializeField]bool mouseLook, surgeBrake = true, swayBrake = true, heaveBrake = true, coasting;
	[SerializeField] Camera flightCamera;
	[SerializeField] RectTransform mouseLookIndicator;

	#region Input events
	void OnExit(InputAction.CallbackContext context)
	{
		CustomEvents.TriggerEvent("ControlChange", "FPS");
	}

	void OnSurgeAction(InputAction.CallbackContext context)
	{
		float thrust = context.ReadValue<float>();
		if (thrust == 0) surgeBrake = true;
		else surgeBrake = false;
		CalculateSurgeThrust(thrust);
	}

	void OnSwayAction(InputAction.CallbackContext context)
	{
		if (mouseLook)
		{
			float thrust = context.ReadValue<float>();
			if (thrust == 0) swayBrake = true;
			else swayBrake = false;
			CalculateSwayThrust(thrust);
		}
	}

	void OnHeaveAction(InputAction.CallbackContext context)
	{
		if (mouseLook)
		{
			float thrust = context.ReadValue<float>();
			if (thrust == 0) heaveBrake = true;
			else heaveBrake = false;
			CalculateHeaveThrust(thrust);
		}
	}

	void OnToggleMouseLook(InputAction.CallbackContext context)
	{
		mouseLook = !mouseLook;
		if(!mouseLook)
		{
			Cursor.lockState = CursorLockMode.None;
			mouseLookIndicator.localPosition = Vector2.zero;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
		}
	}

	void OnFlagshipUpdate()
	{
		acceleration = flagshipStats.GetMaxAcceleration();
	}
	#endregion

	#region Calculators
	private void CalculateSurgeThrust(float thrust)
	{
		if (thrust > 0)
			thrustDelta.z += thrust * acceleration["forward"] * Time.deltaTime;
		else if (thrust < 0)
			thrustDelta.z += thrust * acceleration["reverse"] * Time.deltaTime;
		else
		{
			if (!coasting && surgeBrake)
			{
				thrustDelta.z = 0;
			}
		}
	}

	private void CalculateSwayThrust(float thrust)
	{
		if(thrust != 0)
			thrustDelta.x += thrust * acceleration["sway"] * Time.deltaTime;
		else
		{
			if (!coasting && swayBrake)
			{
				thrustDelta.x = 0;
			}
		}
	}

	private void CalculateHeaveThrust(float thrust)
	{
		if(thrust != 0)
			thrustDelta.y += thrust * acceleration["heave"] * Time.deltaTime;
		else
		{
			if (!coasting && heaveBrake)
			{
				thrustDelta.y = 0;
			}
		}
	}

	void CalculateRotation(float maxPerFrame, float pitchIn, float yawIn, out float pitchOut, out float yawOut)
	{
		if (pitchIn == 0)
		{
			if (Mathf.Abs(rotateVelocity.x) > maxPerFrame)
			{
				pitchOut = cancelRotation(rotateVelocity.x, maxPerFrame) * acceleration["pitch"];
			}
			else
			{
				//Kill pitch rotation
				rotateVelocity.x = 0;
				pitchOut = 0;
			}
		}
		else
		{
			pitchOut = pitchIn;
		}
		if (yawIn == 0)
		{
			if (Mathf.Abs(rotateVelocity.y) > maxPerFrame)
			{
				yawOut = cancelRotation(rotateVelocity.y, maxPerFrame) * acceleration["yaw"];
			}
			else
			{
				//Kill pitch rotation
				rotateVelocity.y = 0;
				yawOut = 0;
			}
		}
		else
		{
			yawOut = yawIn;
		}
	}
	#endregion

	Vector3 NormalizeThrust()
	{
		Vector3 normalized = thrustDelta.z * flagship.forward;
		normalized += thrustDelta.x * flagship.right;
		normalized += thrustDelta.y * flagship.up;
		return normalized;
	}

	float cancelRotation(float velocity, float maxPerFrame)
	{
		if (velocity > maxPerFrame)
		{
			return -1;
		}
		else if (velocity < maxPerFrame)
		{
			return 1;
		}
		else
		{
			return -velocity / maxPerFrame; //Flips velocity value to return an inverted value
		}
	}

	void ShipTurnAngle()
	{
		float pitch;
		float yaw;
		float maxPerFrame = turnSpeed * Time.deltaTime;
		if (!mouseLook)
		{
			float tPitch = -inputs.Flight.Heave.ReadValue<float>();
			float tYaw = inputs.Flight.Sway.ReadValue<float>();
			CalculateRotation(maxPerFrame, tPitch, tYaw, out pitch, out yaw);
		}
		else
		{
			Vector2 mouseDelta = inputs.Flight.Look.ReadValue<Vector2>();
			//Debug.Log($"MouseLook mouse delta was {mouseDelta}");
			mouseLookIndicator.localPosition = Vector3.ClampMagnitude((Vector3)mouseDelta + mouseLookIndicator.localPosition, 100);
			if (Mathf.Abs(mouseLookIndicator.localPosition.y) > mouseLookDeadzone)
			{
				pitch = -mouseDelta.y;
			}
			else
			{
				if (Mathf.Abs(rotateVelocity.x) > maxPerFrame)
				{
					pitch = cancelRotation(rotateVelocity.x, maxPerFrame) * acceleration["pitch"];
				}
				else
				{
					//Kill pitch rotation
					pitch = 0;
					rotateVelocity.x = 0;
				}
			}
			if (Mathf.Abs(mouseLookIndicator.localPosition.x) > mouseLookDeadzone)
			{
				yaw = mouseDelta.x;
			}
			else
			{
				if (Mathf.Abs(rotateVelocity.y) > maxPerFrame)
				{
					yaw = cancelRotation(rotateVelocity.y, maxPerFrame) * acceleration["yaw"];
				}
				else
				{
					//Kill yaw rotation
					yaw = 0;
					rotateVelocity.y = 0;
				}
			}
		}
		Vector3 normalizedPerFrame = new Vector3(pitch, yaw, 0) * maxPerFrame;
		rotateVelocity += normalizedPerFrame;
		flagship.rotation = Quaternion.Euler(Vector3.Lerp(flagship.eulerAngles, flagship.eulerAngles + rotateVelocity, maxPerFrame));
	}

	#region Overrides
	public override void OnControlChange(string newControls)
	{
		if (newControls == "Helm")
		{
			//Debug.Log("Enabling helm controls");
			inputs.Flight.Enable();
			flightCamera.gameObject.SetActive(true);
		}
		else
		{
			inputs.Flight.Disable();
			flightCamera.gameObject.SetActive(false);
		}
	}
	public override void Interact()
	{
		CustomEvents.TriggerEvent("ControlChange", "Helm");
	}
	#endregion

	#region Unity methods
	private void Start()
	{
		//For now, set up the accelleration dictionary
		flightCamera.gameObject.SetActive(false);
		acceleration = flagshipStats.GetMaxAcceleration();
		CustomEvents.StartListening("ControlChange", OnControlChange);
		CustomEvents.StartListening("FlagshipChange", OnFlagshipUpdate);
	}

	private void Update()
	{
		//moveToTarget.position += thrustDelta;
		moveToTarget.position += NormalizeThrust();
		moveToTarget.rotation = flagship.rotation;
		flagship.position = Vector3.Lerp(flagship.position, moveToTarget.position, Time.deltaTime);
		ShipTurnAngle();
		if (!coasting)
		{
			if(surgeBrake)
			{
				if (thrustDelta.z > 0)
				{
					if (thrustDelta.z > (acceleration["reverse"] * Time.deltaTime))
					{
						CalculateSurgeThrust(-1);
					}
					else
					{
						CalculateSurgeThrust(-Mathf.Abs(thrustDelta.z / (acceleration["reverse"] * Time.deltaTime)));
					}
				}
				else
				{
					if (thrustDelta.z > (acceleration["forward"] * Time.deltaTime))
					{
						CalculateSurgeThrust(1);
					}
					else
					{
						CalculateSurgeThrust(Mathf.Abs(thrustDelta.z / (acceleration["forward"] * Time.deltaTime)));
					}
				}
			}
			if (swayBrake)
			{
				if (thrustDelta.x > 0)
				{
					if (thrustDelta.x > (acceleration["sway"] * Time.deltaTime))
					{
						CalculateSurgeThrust(-1);
					}
					else
					{
						CalculateSurgeThrust(-Mathf.Abs(thrustDelta.x / (acceleration["sway"] * Time.deltaTime)));
					}
				}
				else
				{
					if (thrustDelta.x > (acceleration["sway"] * Time.deltaTime))
					{
						CalculateSurgeThrust(1);
					}
					else
					{
						CalculateSurgeThrust(Mathf.Abs(thrustDelta.x / (acceleration["sway"] * Time.deltaTime)));
					}
				}
			}
			if (heaveBrake)
			{
				if (thrustDelta.y > 0)
				{
					if (thrustDelta.y > (acceleration["heave"] * Time.deltaTime))
					{
						CalculateSurgeThrust(-1);
					}
					else
					{
						CalculateSurgeThrust(-Mathf.Abs(thrustDelta.y / (acceleration["heave"] * Time.deltaTime)));
					}
				}
				else
				{
					if (thrustDelta.y > (acceleration["heave"] * Time.deltaTime))
					{
						CalculateSurgeThrust(1);
					}
					else
					{
						CalculateSurgeThrust(Mathf.Abs(thrustDelta.y / (acceleration["heave"] * Time.deltaTime)));
					}
				}
			}
		}
	}

	private void OnEnable()
	{
		InputMaster.FlightActions controlSet = inputs.Flight;
		controlSet.Surge.performed += OnSurgeAction;
		controlSet.Sway.performed += OnSwayAction;
		controlSet.Heave.performed += OnHeaveAction;
		controlSet.MouseLook.performed += OnToggleMouseLook;
		controlSet.Exit.performed += OnExit;
	}

	private void OnDisable()
	{
		InputMaster.FlightActions controlSet = inputs.Flight;
		controlSet.Surge.performed -= OnSurgeAction;
		controlSet.Sway.performed -= OnSwayAction;
		controlSet.Heave.performed -= OnHeaveAction;
		controlSet.MouseLook.performed -= OnToggleMouseLook;
		controlSet.Exit.performed -= OnExit;
	}

	#endregion
}
