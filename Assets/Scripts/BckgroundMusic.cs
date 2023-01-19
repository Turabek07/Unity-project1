using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BckgroundMusic : MonoBehaviour
{
    private static BckgroundMusic music;
    void Awake()
    {
        if(music==null)
        {
            music = this;
            DontDestroyOnLoad(music);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
