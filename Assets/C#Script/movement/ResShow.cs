using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResShow : MonoBehaviour
{
        public static ResShow instance;

        public GameObject resUI;
        public GameObject mainUI;
        public PlayerMovement player;
       
    private void Awake() {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void ToggleShop(){
        resUI.SetActive(!resUI.activeSelf);
        mainUI.SetActive(!mainUI.activeSelf);
      
    }
   
}
