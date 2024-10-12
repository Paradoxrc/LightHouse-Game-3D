using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour
{


    public GameObject winscreen;
    public int CoinCount = 0;
    public player player;
    public Text CoinText;
    public AudioSource keySound;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (CoinCount == 3)
        {
            door.SetActive(false);
        }


    }
    public void playCollectSound()
    {
        keySound.Play();
    }
}
