using UnityEngine;

public class Destroy : MonoBehaviour
{
	private void Start()
	{
		Object.Destroy(base.gameObject, 0.1f);
	}
}
