using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Switch : MonoBehaviour
{

    public GameObject[] background;
    public GameObject[] button;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(index >=4){ index = 4;}
       
        if(index<0){ index=0;}
    

        if(index==0)
        {
            background[0].gameObject.SetActive(true);
            button[0].gameObject.SetActive(false);

        }else{button[0].gameObject.SetActive(true);}
        if(index==4){
             button[1].gameObject.SetActive(false);
        }else{button[1].gameObject.SetActive(true);}
       
    }
    public void Next(){
        index +=1;
   

        for(int i=0; i< background.Length;i++){
            background[i].gameObject.SetActive(false);
         
            background[index].gameObject.SetActive(true);
           

        }
        Debug.Log(index);
    }
      public void Previous(){
        index -=1;
       

        for(int i = 0; i< background.Length;i++){
            
            background[i].gameObject.SetActive(false);
          
            background[index].gameObject.SetActive(true);
      

        }
        Debug.Log(index);
    }
}
