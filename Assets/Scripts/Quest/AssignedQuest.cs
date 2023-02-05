using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignedQuest : MonoBehaviour
{
    [SerializeField] Quest quest;

    public void ActivateQuestOnSelf() {
        if (!quest.IsComplete())
        {
            if (!quest.IsStarted())
            {
                QuestManager.ManageQuest.StartQuest(quest, true);
            }
            else {
                Debug.Log("Quest has been started");
            }
        }
        else {
            Debug.Log("Quest is complete");
        }
    }
}
