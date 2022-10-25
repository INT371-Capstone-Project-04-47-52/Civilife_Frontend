using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkShow : MonoBehaviour
{
        public static WorkShow instance;

        public GameObject workUI;
        public PlayerMovement player;
        public GameObject mainUI;
        
    private void Awake() {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void ToggleShop(){
        workUI.SetActive(!workUI.activeSelf);
         mainUI.SetActive(!mainUI.activeSelf);
  
    }
   
}
