using UnityEngine;
using System.Collections;

public class SoundPlayer : MonoBehaviour {

    public void Wake() {
        DontDestroyOnLoad(gameObject);
    }
}
