using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI timerText;

	[SerializeField]
	private float remainingTime;

	public GameObject EndMenu;

	public GameObject Gun;

	public TMP_Text score;

	public TMP_Text accuracy;

	public TMP_Text high_score;

	public TMP_Text high_acc;

	private void Update()
	{
		if (remainingTime > 0f)
		{
			remainingTime -= Time.deltaTime;
		}
		else
		{
			remainingTime = 0f;
			timerText.text = "DONE";
			timerText.color = Color.red;
			score.text = PlayerPrefs.GetInt("score").ToString();
			accuracy.text = PlayerPrefs.GetInt("accuracy") + " %";
			if (PlayerPrefs.GetInt("score") == PlayerPrefs.GetInt("highest_score"))
			{
				if (PlayerPrefs.GetInt("accuracy") > PlayerPrefs.GetInt("highest_acc"))
				{
					PlayerPrefs.SetInt("highest_acc", PlayerPrefs.GetInt("accuracy"));
				}
			}
			else if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highest_score"))
			{
				PlayerPrefs.SetInt("highest_score", PlayerPrefs.GetInt("score"));
				PlayerPrefs.SetInt("highest_acc", PlayerPrefs.GetInt("accuracy"));
			}
			high_score.text = PlayerPrefs.GetInt("highest_score").ToString();
			high_acc.text = PlayerPrefs.GetInt("highest_acc") + " %";
			EndMenu.SetActive(value: true);
			Gun.SetActive(value: false);
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
		int num = Mathf.FloorToInt(remainingTime / 60f);
		int num2 = Mathf.FloorToInt(remainingTime % 60f);
		if (remainingTime != 0f)
		{
			if (remainingTime <= 10f)
			{
				timerText.text = $"{num2:0}";
			}
			else if (remainingTime <= 60f)
			{
				timerText.text = $"{num2:00}";
			}
			else
			{
				timerText.text = $"{num:0}:{num2:00}";
			}
		}
	}
}
