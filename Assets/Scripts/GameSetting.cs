using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    public static GameSetting Setting { get; private set; }

    public bool AudioEnable { get; set; }

    private void Awake()
    {
        if (Setting != null && Setting != this)
        {
            Destroy(this);
        }
        else {
            Setting = this;
            DontDestroyOnLoad(Setting);
        }
    }

    private void Start()
    {
        AudioEnable = true;
    }

    public void ToggleAudio() {
        AudioEnable = !AudioEnable;
    }
}
