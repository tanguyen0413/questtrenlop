using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class DailyQuestData
{
    public string description;
    public string taskcount;
    public Sprite reward;
    public string rewardQuality;
}

//[CreateAssetMenu(fileName = "Quest Database", menuName = "Quest Database", order = 51)]
//public class QuestDatabase : ScriptableObject
//{
//    public DailyQuestData[] questDatas;
//}
