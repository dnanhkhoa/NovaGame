using UnityEngine;

// Done

public class ScoreManager
{
	public static int score = 0;

	public static void Update(int addValue)
	{
		score += addValue;
	}

	public static int GetHightscore()
	{
        return PlayerPrefs.GetInt("HighScore", 0);
	}

	public static void SetHighScore()
	{
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
	}
}
