using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    protected int health = 5;
    [SerializeField]
    protected int maxHealth = 10;

    public void SavePlayer(){
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer(){
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
