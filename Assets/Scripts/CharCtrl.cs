using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharCtrl : ControlBase
{
	[SerializeField] float moveSpeed, cameraSensitivity, rotX, rotY, cameraTiltLimit;
	[SerializeField] Transform root;
	[SerializeField] LayerMask interactMask;
	Rigidbody rigidBody;
	Vector3 moveDirection;
	[SerializeField]bool cameraMoving = false;

	private void OnInteract(InputAction.CallbackContext context)
	{
		//Debug.Log("Interacted");
		//Will need to manually filter between single and double clicks
		Vector3 mousePosition = inputs.Admiral.MousePosition.ReadValue<Vector2>();
		Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(mouseRay,out hit, 3f, interactMask))
		{
			if (hit.collider.tag == "Station")
			{
				ControlBase controllable = hit.collider.GetComponent<ControlBase>();
				controllable.Interact();
			}
		}
	}

	void OnMoveInput(InputAction.CallbackContext context)
	{
		Vector2 moveInput = context.ReadValue<Vector2>();
		float horizontal = moveInput.x;
		float vertical = moveInput.y;
		moveDirection = (transform.forward * vertical) + (transform.right * horizontal);
		//Debug.Log($"Input recieved: {moveDirection}");
	}

	void OnMouseDelta(InputAction.CallbackContext context)
	{
		if (cameraMoving)
		{
			Vector2 mouseInput = context.ReadValue<Vector2>() * cameraSensitivity;
			//Debug.Log($"Input recieved: {mouseInput}");
			Vector3 currentRot = Camera.main.transform.eulerAngles;
			//Debug.Log($"Camera current rotation is : {currentRot}");
			root.Rotate(0, mouseInput.x, 0);
			rotX -= mouseInput.y;
			rotX = Mathf.Clamp(rotX, -cameraTiltLimit, cameraTiltLimit);
			rotY += mouseInput.x;
			if (rotY >= 360)
			{
				rotY = rotY - 360;
			}
			else
			{
				rotY = rotY + 360;
			}
			Camera.main.transform.localEulerAngles = new Vector3(rotX * cameraSensitivity, 0, 0);
		}
	}

	private void CameraControl(InputAction.CallbackContext context)
	{
		cameraMoving = !cameraMoving;
		//Debug.Log($"Right button is being held? {cameraMoving}");
	}

	public override void OnControlChange(string newControls)
	{
		if (newControls == "FPS")
		{
			inputs.Admiral.Enable();
			rigidBody.isKinematic = false;
		}
		else
		{
			//Debug.Log("Disabling FPS controls");
			inputs.Admiral.Disable();
			rigidBody.isKinematic = true;
		}
	}

	#region Unity methods
	private void Start()
	{
		CustomEvents.StartListening("ControlChange", OnControlChange);
		rigidBody = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		rigidBody.velocity += moveDirection * moveSpeed * Time.deltaTime;
		//transform.rotation = Quaternion.RotateTowards(transform.rotation,)
	}

	private void OnEnable()
	{
		inputs.Admiral.Enable();
		inputs.Admiral.Interact.performed += OnInteract;
		inputs.Admiral.Movement.performed += OnMoveInput;
		inputs.Admiral.Movement.canceled += OnMoveInput;
		inputs.Admiral.Look.performed += OnMouseDelta;
		inputs.Admiral.CameraMove.performed += CameraControl;
		inputs.Admiral.CameraMove.canceled += CameraControl;
	}

	private void OnDisable()
	{
		inputs.Admiral.Interact.performed -= OnInteract;
		inputs.Admiral.Movement.performed -= OnMoveInput;
		inputs.Admiral.Movement.canceled -= OnMoveInput;
		inputs.Admiral.Look.performed -= OnMouseDelta;
	}

	#endregion
}
