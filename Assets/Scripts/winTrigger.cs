using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrigegr : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter(Collider other)
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
