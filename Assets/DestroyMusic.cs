﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMusic : MonoBehaviour
{
    GameObject music;

    private void Awake()
    {
        music = GameObject.Find("Music(Clone)");
        if (music) 
            Destroy(music);
    }
}
