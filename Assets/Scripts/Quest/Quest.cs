using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public string id;
    public string name;
    public string description;
    bool isStarted = false;
    bool isCompleted = false;

    public void StartQuest(bool isStart) {
        isStarted = isStart;
    }

    public void CompleteQuest(bool isComplete) {
        isCompleted = isComplete;
    }

    public bool IsStarted() {
        return isStarted;
    }

    public bool IsComplete() {
        return isCompleted;
    }
}
