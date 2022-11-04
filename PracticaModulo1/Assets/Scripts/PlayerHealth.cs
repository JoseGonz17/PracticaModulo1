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

    public int salud1, salud2;

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
            Debug.Log("He muerto :(");
            transform.position = new Vector3(0, 0, 0);
            currentHealth = MaxHealth;
        }
        else
        {
            Debug.Log("He caido en una trampa. Salud restante = " + currentHealth);
        }
    }

    public void TakeHealth(int healthTaken) 
    {
        
        if (currentHealth <= 50)
        {
            currentHealth += healthTaken;
            healthText.text = currentHealth.ToString();
            Debug.Log("He recuperado vida,ahora tengo " + currentHealth + " puntos de salud");
        }
    }
}