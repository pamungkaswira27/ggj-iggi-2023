using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [Header("Menu Button")]
    [SerializeField] Button playBtn;
    [SerializeField] Button audioBtn;

    private void Awake()
    {
        playBtn.onClick.AddListener(() => PlayGame());
        audioBtn.onClick.AddListener(() => ToggleAudio());
    }

    private void Start()
    {
        AudioDisplay();
    }

    void PlayGame() {
        SceneManager.LoadScene(1);
    }

    void ToggleAudio() {
        GameSetting.Setting.ToggleAudio();
        AudioDisplay();
    }

    void AudioDisplay() {
        TextMeshProUGUI text = audioBtn.GetComponentInChildren<TextMeshProUGUI>();

        if (GameSetting.Setting.AudioEnable)
            text.text = "Audio: On";
        else
            text.text = "Audio: Off";
    }
}
