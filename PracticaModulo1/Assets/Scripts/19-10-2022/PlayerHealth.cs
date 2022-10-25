using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 inicialPosition;

    private void Start()
    {
        inicialPosition = transform.position;
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        if (currentHealth <= 0)
        {
            Debug.Log("Estoy muerto");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("Me han hecho daño,me queda " + currentHealth + " de vida");
        }
    }
}