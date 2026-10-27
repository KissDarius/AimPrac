using System;
using UnityEngine;

public class Gun : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private GunData gunData;

	[SerializeField]
	private Transform muzzle;

	private float timeSinceLastShot;

	private void Start()
	{
		PlayerShoot.shootInput = (Action)Delegate.Combine(PlayerShoot.shootInput, new Action(Shoot));
	}

	private bool CanShoot()
	{
		if (!gunData.reloading)
		{
			return timeSinceLastShot > 1f / (gunData.fireRate / 60f);
		}
		return false;
	}

	public void Shoot()
	{
		if (gunData.currentAmmo > 0 && CanShoot())
		{
			if (Physics.Raycast(muzzle.position, base.transform.forward, out var hitInfo, gunData.maxDistance))
			{
				hitInfo.transform.GetComponent<IDamageable>()?.Damage(gunData.damage);
			}
			timeSinceLastShot = 0f;
		}
	}

	private void Update()
	{
		timeSinceLastShot += Time.deltaTime;
	}
}
