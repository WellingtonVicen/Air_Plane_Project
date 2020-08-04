using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colunas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.GetComponent<Player>() != null)
        {
            GameControl.gameControl.AirScore();
            GetComponent<AudioSource>().Play();
        }
      
    }

}
