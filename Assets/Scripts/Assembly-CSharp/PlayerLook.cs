using UnityEngine;

public class PlayerLook : MonoBehaviour
{
	[SerializeField]
	private float sensX;

	[SerializeField]
	private float sensY;

	[SerializeField]
	private Transform cam;

	[SerializeField]
	private Transform orientation;

	private float mouseX;

	private float mouseY;

	private float multiplier = 0.001f;

	private float xRotation;

	public float yRotation;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update()
	{
		MyInput();
		cam.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
		orientation.transform.rotation = Quaternion.Euler(0f, yRotation, 0f);
	}

	private void MyInput()
	{
		mouseX = Input.GetAxisRaw("Mouse X");
		mouseY = Input.GetAxisRaw("Mouse Y");
		yRotation += mouseX * sensX * multiplier;
		xRotation -= mouseY * sensY * multiplier;
		xRotation = Mathf.Clamp(xRotation, -80f, 80f);
	}
}
