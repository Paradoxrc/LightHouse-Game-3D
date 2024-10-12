using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCollectableOnTrigger : MonoBehaviour
{


    public coinScript cs;

    public player player;

    public GameObject obj;

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        cs.playCollectSound();
        cs.CoinCount += 1; // Increment the coin count
        cs.CoinText.text = "Keys - " + cs.CoinCount.ToString() + "/3";
        Destroy(obj);

    }



}
