using System;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
	public static Action shootInput;

	public static Action reloadInput;

	public GameObject Timer;

	public GameObject Timerholder;

	public GameObject ShootMessage;

	[SerializeField]
	private KeyCode reloadKey;

	public bool firstShoot;

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			shootInput?.Invoke();
			if (!firstShoot)
			{
				Timer.SetActive(value: true);
				Timerholder.SetActive(value: false);
				ShootMessage.SetActive(value: false);
				firstShoot = true;
			}
		}
		if (Input.GetKeyDown(reloadKey))
		{
			reloadInput?.Invoke();
		}
	}
}
