using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public ShopManager shopmanager;

    public GameObject questWindow;
    //public GameObject buttonAccept;

    public Text titleText;
    //public Text descriptionText;
    //public Text experienceText;
   // public Text goldText;
   // public Text happyText;
    void Start(){
  questWindow.SetActive(true);
        titleText.text = quest.title;
        // descriptionText.text = quest.description;
        // experienceText.text = quest.experienceReward.ToString();
        // happyText.text = quest.happyReward.ToString();
        // goldText.text = quest.goldReward.ToString();
        quest.isActive = true;
        shopmanager.quest = quest;

    }
    public void OpenQuestWindow(){
Debug.Log("dd");
      


    }
    // public void AcceptQuest(){
    //     questWindow.SetActive(true);
    //     quest.isActive = true;
    //     player.quest = quest;
    // }

   


}
