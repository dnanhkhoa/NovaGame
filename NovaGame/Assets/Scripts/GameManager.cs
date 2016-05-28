using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	static LevelManager levelManager = new LevelManager();

	ThrawerManager thrawerManager = new ThrawerManager();
	WalkerManager walkerManager = new WalkerManager();

    public AudioSource auSrcIncreaseScore;
	

	// Use this for initialization
	void Start () {
        auSrcIncreaseScore = GetComponentInChildren<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GameObject scoreDisplayer = GameObject.Find("ScoreDisplayer");
        scoreDisplayer.SendMessage("setScore", ScoreManager.score);
	}


	void SetIdleWalker(GameObject walker)
	{
		walkerManager.SetIdleWalker(walker);
	}

	void SetIdleWalkerForever(GameObject walker, Vector3 position)
	{
		walkerManager.SetIdleForever(walker, position);
	}


    void UpdateScore(int addValue) {
        ScoreManager.Update(addValue);
        //AudioSource.PlayClipAtPoint(auArchiveScore, gameObject.transform.position);
        auSrcIncreaseScore.Play();
    }

	
	public void InvokeGameOver()
	{
		levelManager.LoadLevel("Lose");
	}
}
