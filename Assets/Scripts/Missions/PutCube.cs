using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PutCube : MonoBehaviour
{
    public GameObject cubo1;
    public void Putcubo()
    {
        if (cubo1.tag == "cubo")
        {
            SceneManager.LoadScene("Future");
        }
    }
}
