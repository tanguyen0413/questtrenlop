using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuestManager : MonoBehaviour
{
    public QuestDatabase questDatabase;
    public DailyQuestItemHandler dailyQuestItemHandler;
    public Transform rootUiContent;

    private void Start()
    {
        foreach (var questData in questDatabase.questDatas)
        {
            CreateQuest(questData);
        }
    }
    private void CreateQuest(DailyQuestData questData)
    {
        var quest = Instantiate(dailyQuestItemHandler, rootUiContent);
        quest.SetData(questData);
    }
}
