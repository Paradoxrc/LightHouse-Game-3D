using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject map;
    public int maxHealth = 3;
    public int currentHealth = 3;
    public playerHealthBar healthBar;
    private bool canTakeDamage = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Tab))
        {
            map.SetActive(true);
        }
        else
        {
            map.SetActive(false);
        }


    }

    public void playerTakeDamage(int damage)
    {
        if (!canTakeDamage)
            return; // If not allowed to take damage, exit the method




        currentHealth -= damage;



        canTakeDamage = false;



    }


    private IEnumerator ResetDamageCooldown(float cooldownDuration)
    {
        yield return new WaitForSeconds(cooldownDuration);
        canTakeDamage = true;
    }
}
