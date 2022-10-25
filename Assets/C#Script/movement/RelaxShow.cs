using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelaxShow : MonoBehaviour
{
        public static RelaxShow instance;

        public GameObject relaxUI;
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
        relaxUI.SetActive(!relaxUI.activeSelf);
         mainUI.SetActive(!mainUI.activeSelf);
        
    }
   
}
