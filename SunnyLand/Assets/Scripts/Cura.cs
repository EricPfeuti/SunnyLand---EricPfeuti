using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cura : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeito;
    private bool vidaColetada = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            if (vidaColetada) return;
            gameManager.Heal();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            vidaColetada = true;
        }
    }


}
