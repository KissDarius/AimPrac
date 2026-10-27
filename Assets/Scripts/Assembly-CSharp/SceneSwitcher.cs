using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
	public GameObject MainMenu;

	public GameObject OptionsMenu;

	public void OpenScene(int index)
	{
		SceneManager.LoadScene(index);
	}

	public void ChangeToOptionsMenu()
	{
		MainMenu.SetActive(value: false);
		OptionsMenu.SetActive(value: true);
	}

	public void ChangeToMainMenu()
	{
		MainMenu.SetActive(value: true);
		OptionsMenu.SetActive(value: false);
	}

	public void CloseApp()
	{
		Application.Quit();
	}
}
