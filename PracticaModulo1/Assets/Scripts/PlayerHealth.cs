using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    public Text healthText;

    private void Start()
    {
        currentHealth = MaxHealth;
        healthText.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        healthText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            Debug.Log("estoy muerto");
            transform.position = new Vector3(0, 0, 0);
            currentHealth = MaxHealth;
        }
        else
        {
            Debug.Log("me han echo daño, salud restante " + currentHealth);
        }
    }
}