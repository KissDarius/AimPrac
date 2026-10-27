using UnityEngine;

public class PlayAudio : MonoBehaviour
{
	public GameObject audioObj;

	public void DropAudio()
	{
		Object.Instantiate(audioObj, base.transform.position, base.transform.rotation);
	}
}
