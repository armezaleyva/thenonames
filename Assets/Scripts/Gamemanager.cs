﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    
    void Awake(){
        if(!instance){
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else if (instance != this){
            Destroy(this);
        }
    }

}
