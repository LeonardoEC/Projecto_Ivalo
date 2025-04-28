using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombi : MonoBehaviour
{
    public Zombi_data zombi_Data;

    GameObject jugador;


    void Start()
    {
        jugador = GameObject.Find("Player");
    }


    void Update()
    {
        transform.LookAt(jugador.transform);
        if(zombi_Data == null)
        {
            GetComponent<Rigidbody>().velocity = transform.forward * 1;
        }
        else
        {
            GetComponent<Rigidbody>().velocity = transform.forward * zombi_Data.velocidad;
        }
    }
}
