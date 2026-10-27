using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour, IDamageable
{
	public float health = 20f;

	public GameObject gun;

	private AudioSource shootingSound;

	private void Start()
	{
		shootingSound = GetComponent<AudioSource>();
	}

	public void Damage(float damage)
	{
		shootingSound.Play();
		StartCoroutine(StartRecoil());
		health -= damage;
		if (health == 0f)
		{
			Score.instance.AddPoint(target: true, wrong: false);
			base.transform.position = TargetsSpawn.Instance.GetRandomPossition();
			health = 20f;
		}
		else
		{
			Score.instance.AddPoint(target: false, wrong: true);
			health = 21f;
		}
	}

	private IEnumerator StartRecoil()
	{
		gun.GetComponent<Animator>().Play("Recoil");
		yield return new WaitForSeconds(0.1f);
		gun.GetComponent<Animator>().Play("New State");
	}
}
