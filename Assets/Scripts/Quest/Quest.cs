using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest : MonoBehaviour
{
    public string id;
    public string name;
    public string description;
    bool isStarted;
    bool isCompleted;

    public void StartQuest(bool isStart) {
        isStarted = isStart;
    }

    public void CompleteQuest(bool isComplete) {
        isCompleted = isComplete;
    }
}
