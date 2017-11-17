using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Quest : MonoBehaviour
{

    [System.Serializable]
    public struct Quests
    {
        public string questName;
        public int questState;

        public Quests(string QuestName, int QuestState)
        {
            questName = QuestName;
            questState = QuestState;
        }
    }

    [SerializeField] public Quests[] quests;

    // Use this for initialization
    void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
