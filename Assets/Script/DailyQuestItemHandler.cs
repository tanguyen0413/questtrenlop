using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyQuestItemHandler : MonoBehaviour
{
    public DailyQuestData dailyQuestData;
    public Text descriptionText;
    public Image rewardImage;
    public Text taskCountText;

    public Text rewardqualitytext;
    public void SetData(DailyQuestData dailyQuestData)
    {
        Debug.Log("SetData");
        this.dailyQuestData = dailyQuestData;
        UpdateUI();
    }

    public void UpdateUI()
    {
        
        descriptionText.text = dailyQuestData.description;
        rewardImage.sprite = dailyQuestData.reward;
        taskCountText.text = dailyQuestData.taskcount;
        rewardqualitytext.text = dailyQuestData.rewardQuality;
    }
}
