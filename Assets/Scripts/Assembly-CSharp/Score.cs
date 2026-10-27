using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
	public static Score instance;

	public TMP_Text scoreText;

	public TMP_Text accuracyText;

	private int score;

	private int missed;

	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		scoreText.text = score.ToString();
		accuracyText.text = missed + " %";
	}

	public void AddPoint(bool target, bool wrong)
	{
		if (target)
		{
			score++;
		}
		else if (wrong)
		{
			missed++;
		}
		scoreText.text = score.ToString();
		int value = score * 100 / (missed + score);
		accuracyText.text = value + " %";
		PlayerPrefs.SetInt("score", score);
		PlayerPrefs.SetInt("accuracy", value);
	}
}
