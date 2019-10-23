using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public GameObject puertas;
    public void AbrirPuerta()
    {
        puertas.GetComponent<Animator>().SetBool("character_nearby", true);
    }
    public void CerrarPuerta()
    {
        puertas.GetComponent<Animator>().SetBool("character_nearby", false);
    }
}
