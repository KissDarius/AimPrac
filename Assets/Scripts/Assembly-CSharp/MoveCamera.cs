using UnityEngine;

public class MoveCamera : MonoBehaviour
{
	[SerializeField]
	private Transform cameraPosition;

	private void Update()
	{
		base.transform.position = cameraPosition.position;
	}
}
