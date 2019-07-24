using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public float speed = 6.0F;
	public float gravity = 20.0F;
	
	private Vector3 moveDirection = Vector3.zero;
	public CharacterController controller;

	void Start(){
		controller = GetComponent<CharacterController>();
	}

	void Update() 
	{
		if (controller.isGrounded) 
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}