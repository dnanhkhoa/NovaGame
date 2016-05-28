using UnityEngine;
using System.Collections;

public class DisplayScore : MonoBehaviour {

    public Sprite[] numberSprites;
    public SpriteRenderer Units, Tens, Hundreds, Thousands;

    int previousScore = -1;
    public int score = 0;
    public float padding = 0.35f;
    public bool leftToRight = false;

	// Use this for initialization
	void Start () {
        if (leftToRight)
        {
            Thousands.transform.position = Units.transform.position;
            Hundreds.transform.position = Thousands.transform.position + new Vector3(padding, 0, 0);
            Tens.transform.position = Hundreds.transform.position + new Vector3(padding, 0, 0);
            Units.transform.position = Tens.transform.position + new Vector3(padding, 0, 0);
        }
        else
        {
            Tens.transform.position = Units.transform.position + new Vector3(-padding, 0, 0);
            Hundreds.transform.position = Tens.transform.position + new Vector3(-padding, 0, 0);
            Thousands.transform.position = Hundreds.transform.position + new Vector3(-padding, 0, 0);
        }
        reset();
	}
	
	// Update is called once per frame
	void Update () {
        if (previousScore != score)
        {
            showUnits();
            if (score < 10)
            {
                Units.sprite = numberSprites[score];
            }
            else if (score >= 10 && score < 100)
            {
                (Tens.gameObject as GameObject).SetActive(true);
                Tens.sprite = numberSprites[score / 10];
                Units.sprite = numberSprites[score % 10];
            }
            else if (score >= 100 && score < 1000)
            {
                (Hundreds.gameObject as GameObject).SetActive(true);
                Hundreds.sprite = numberSprites[score / 100];
                int rest = score % 100;
                (Tens.gameObject as GameObject).SetActive(true);
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
            else
            {
                showUnits();
                (Thousands.gameObject as GameObject).SetActive(true);
                Thousands.sprite = numberSprites[score / 1000];
                int rest = score % 1000;
                (Hundreds.gameObject as GameObject).SetActive(true);
                Hundreds.sprite = numberSprites[rest / 100];
                rest = rest % 100;
                (Tens.gameObject as GameObject).SetActive(true);
                Tens.sprite = numberSprites[rest / 10];
                Units.sprite = numberSprites[rest % 10];
            }
            // Update
            previousScore = score;
        }
	}

    void reset()
    {
        showUnits();
        Units.sprite = numberSprites[0];
    }

    void showUnits()
    {
        (Tens.gameObject as GameObject).SetActive(false);
        (Hundreds.gameObject as GameObject).SetActive(false);
        (Thousands.gameObject as GameObject).SetActive(false);
    }


    void setScore(int value) {
        score = value;
    }
}
