using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public player player;

    public int Damage = 1;
    public GameObject obj;
    public GameObject loseScreen;
    private bool canTakeDamage = true; // To track if the player can take damage
    private float cooldownTime = 2f;
    public AudioSource hurtSound;  // 2 seconds cooldown time

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (canTakeDamage)
        {
            hurtSound.Play();
            player.currentHealth -= Damage;
            canTakeDamage = false;

            if (player.currentHealth <= 0)
            {
                loseScreen.SetActive(true);
                Destroy(obj);
            }
            else
            {
                StartCoroutine(DamageCooldown());
            }
        }
    }

    // Coroutine to handle the damage cooldown
    private IEnumerator DamageCooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        canTakeDamage = true;
    }
}
