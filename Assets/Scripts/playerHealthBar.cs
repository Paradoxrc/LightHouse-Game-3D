using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthBar : MonoBehaviour
{
    public player player;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (player.currentHealth == 2)
        {
            heart3.SetActive(false);
        }
        else if (player.currentHealth == 1)
        {
            heart2.SetActive(false);
        }
        else if (player.currentHealth == 0)
        {
            heart1.SetActive(false);
        }
    }
}
