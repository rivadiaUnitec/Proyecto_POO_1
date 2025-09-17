using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Estadisca playerVida;
    public float dano = 10;

    public void Usar()
    {
        playerVida.vida = playerVida.vida - this.dano;
    }

    

    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag=="Player")
        {
           
            Usar();
            this.gameObject.SetActive(false);
        }
    }

}//Puerta de Infierno
