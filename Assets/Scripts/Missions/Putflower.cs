using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Putflower : MonoBehaviour
{
    public GameObject flower;
    public GameObject terrain1;
    public GameObject terrain2;
    public GameObject terrain3;
    public GameObject terrain4;

    private bool canContinue = true;

    public void Putflor()
    {
        if (flower.tag == "cubo")
        {
            StartCoroutine(TransitionTerrains());
            //SceneManager.LoadScene("Scene6");
        }
    }

    IEnumerator TransitionTerrains() {
        yield return StartCoroutine(LoadTerrain(terrain1, terrain2));
        yield return StartCoroutine(LoadTerrain(terrain2, terrain3));
        yield return StartCoroutine(LoadTerrain(terrain3, terrain4));
    }


    IEnumerator LoadTerrain(GameObject oldTerrain, GameObject newTerrain) {
        oldTerrain.SetActive(false);
        newTerrain.SetActive(true);
        canContinue = false;

        yield return new WaitForSeconds(5);
    }
}
