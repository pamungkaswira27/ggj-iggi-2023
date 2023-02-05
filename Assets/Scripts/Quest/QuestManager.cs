using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class QuestManager : MonoBehaviour
{
    public static QuestManager ManageQuest { get; private set; }
    Quest activeQuest;

    [SerializeField] GameObject panel;

    private void Awake()
    {
        if (ManageQuest != null && ManageQuest != this)
        {
            Destroy(this);
        }
        else
        {
            ManageQuest = this;
        }
    }

    private void Start()
    {
        DisplayActiveQuest();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            CompleteQuest();
        }
    }

    public void StartQuest(Quest quest, bool isStart)
    {
        quest.StartQuest(isStart);
        activeQuest = quest;
        DisplayActiveQuest();
    }
    public void StartQuest(Quest quest, bool isStart, UnityEvent onQuestStart)
    {
        StartQuest(quest, isStart);
        onQuestStart.Invoke();
    }

    public void CompleteQuest()
    {
        if (activeQuest != null)
        {
            activeQuest.CompleteQuest(true);
            activeQuest = null;
            DisplayActiveQuest();
        }
        else {
            Debug.Log("No active quest");
        }
    }

    public void CompleteQuest(UnityEvent onCompleteQuest)
    {
        CompleteQuest();
        onCompleteQuest.Invoke();
    }


    public void CompleteQuest(Quest quest, bool isComplete)
    {
        quest.CompleteQuest(isComplete);
        activeQuest = null;
        DisplayActiveQuest();
    }
    public void CompleteQuest(Quest quest, bool isComplete, UnityEvent onCompleteQuest)
    {
        CompleteQuest(quest, isComplete);
        onCompleteQuest.Invoke();
    }

    void DisplayActiveQuest() {
        if (activeQuest != null)
        {
            panel.SetActive(true);
            TextMeshProUGUI text = panel.GetComponentInChildren<TextMeshProUGUI>();
            text.text = activeQuest.description;
        }
        else {
            panel.SetActive(false);
        }

    }

}
