using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using JetBrains.Annotations;
using UnityEngine;

[ExecuteInEditMode]
public class Dialogue : MonoBehaviour
{
    //Quest is the required quest
    //QuestState is the state said quest is in, 0 being not started, 1 started, and 2 completed

    [System.Serializable]
    public struct ConversationLine
    {
        public int type;
        public int id;

        public string[] choicesText;
        public int[] choicesDestination;

        public string character;
        public string speech;
        public int pose;

        public ConversationLine(int Type, int ID, string []ChoicesText, int []ChoicesDestination, string Character, string Speech, int Pose)
        {
            type = Type;
            id = ID;

            choicesText = ChoicesText;
            choicesDestination = ChoicesDestination;
            
            character = Character;
            speech = Speech;
            pose = Pose;
        }
    }

    [SerializeField] private bool requireQuest = false;
    [SerializeField] private string Quest = "default";
    [SerializeField] private int QuestState = 1;

    [SerializeField] public ConversationLine[] Text;

    private Quest quest;

    // Use this for initialization
    void Start ()
    {
        quest = GameObject.FindGameObjectWithTag("Quests").transform.GetComponent<Quest>();
        if (requireQuest)
        {
            for (int i = 0; i < quest.quests.Length; i++)
            {
                if (Quest == quest.quests[i].questName)
                {
                    if (QuestState == quest.quests[i].questState)
                    {
                       startConversation(); 
                    }
                }
            }
        }
        else
        {
            startConversation();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void startConversation()
    {
        Debug.Log("Start Test Conversation");
    }
}
