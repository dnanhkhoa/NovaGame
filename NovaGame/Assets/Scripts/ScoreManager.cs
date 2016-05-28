using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ScoreManager
{
	public static int score = 0;

	public static void Update(int addValue)
	{
		score += addValue;
	}

	public static int GetHightscore()
	{
		return 0;
	}

	public static void SetHighScore()
	{

	}
}
