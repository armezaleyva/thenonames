using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Putflower : MonoBehaviour
{
    public GameObject flower;
    public void Putflowe()
    {
        if (flower.tag == "cubo")
        {
            SceneManager.LoadScene("Savetheworld");
        }
    }
}
