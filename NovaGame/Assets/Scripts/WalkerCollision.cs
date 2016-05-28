using UnityEngine;
using System.Collections;

public class WalkerCollision : MonoBehaviour {

    public AudioClip auGarbage_Walker;

	// Use this for initialization
	void Start () {
	
	}

    AudioSource auSrc;

	// Update is called once per frame
	void Update () {
        auSrc = GetComponentInChildren<AudioSource>();
	}


    void OnCollisionEnter2D(Collision2D collision) {
        //Debug.Log("ABC");
        //GameObject manager = GameObject.Find("Manager");

        //if (collision.gameObject.CompareTag("Garbage")) ;

        //AudioSource.PlayClipAtPoint(auGarbage_Walker, gameObject.transform.position);
        auSrc.PlayOneShot(auGarbage_Walker);
    }
}
