using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/QuestDatabase", order = 1)]
public class QuestDatabase : ScriptableObject
{
    public List<DailyQuestData> questDatas;
}