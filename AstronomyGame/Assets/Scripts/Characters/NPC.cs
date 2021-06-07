using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int QuestCount;
    public Player Player;
    public List<DialogueAnimator> QuestsDialogues;
    public QuestsChecker QuestCheker;
    public DialogueTrigger DialogueTrigger;
    public List<Dialogue> Dialogues;
    public DialogueManager DialogueManager;
    public int �urrentQuest;

    public NPC()
    {

    }

    void Start()
    {
        �urrentQuest = 0;
    }

   
    void Update()
    {
        if(�urrentQuest == QuestCheker.CurrentQuest - 1)
        {
            �urrentQuest++;
            TriggerNextQuest();
        }
    }

    public void TriggerNextQuest()
    {
        DialogueManager.StartDialogue(Dialogues[�urrentQuest - 1]);
    }

}
