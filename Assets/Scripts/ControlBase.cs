using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlBase : MonoBehaviour
{
    protected InputMaster inputs;

	public virtual void OnControlChange(string newControls) { }
	public virtual void Interact() { }

	private void Awake()
	{
		inputs = new InputMaster();
	}

}
