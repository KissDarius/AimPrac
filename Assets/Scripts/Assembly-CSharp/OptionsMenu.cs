using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
	public AudioMixer mainMixer;

	public void SetVolume(float volume)
	{
		mainMixer.SetFloat("volume", volume);
	}

	public void SetFullscreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
	}
}
