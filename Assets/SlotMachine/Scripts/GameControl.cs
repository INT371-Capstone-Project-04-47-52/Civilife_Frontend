using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameControl : MonoBehaviour {
    public static event Action HandlePulled = delegate { };

    [SerializeField]
    private TMP_Text prizeText;

    [SerializeField]
    private Row[] rows;

    [SerializeField]
    private Transform handle;

   private string prizeValue;

    private bool resultsChecked = false;

    public GameObject slot;

    // Update is called once per frame
    void Update () {
        // Debug.Log(prizeValue);
        // Debug.Log(resultsChecked);

        if (!rows[0].rowStopped || !rows[1].rowStopped || !rows[2].rowStopped)
        {
            prizeValue = "";
            prizeText.enabled = false;
            resultsChecked = false;
        }
        if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped && !resultsChecked)
        {
            // CheckResults();
            prizeText.enabled = true;
            // prizeText.text = "รูปที่คุณจะวาดก็คือ " + prizeValue;
            prizeText.text = "รูปที่คุณจะวาดก็คือ " + rows[0].stoppedSlot + " " + rows[1].stoppedSlot + " "+ rows[2].stoppedSlot;
           
        }
       
    }

    private void OnMouseDown()
    {
         if (rows[0].rowStopped && rows[1].rowStopped && rows[2].rowStopped)
            StartCoroutine("PullHandle");
    }

    private IEnumerator PullHandle()
    {
        for (int i = 0; i < 15; i += 5)
        {
            handle.Rotate(0f, 0f, i);
            yield return new WaitForSeconds(0.1f);
        }

        HandlePulled();

        for (int i = 0; i < 15; i += 5)
        {
            handle.Rotate(0f, 0f, -i);
            yield return new WaitForSeconds(0.1f);
        }
    }
/*
    private void CheckResults()
    {
        if (rows[0].stoppedSlot == 0 
            && rows[1].stoppedSlot == 0 
            && rows[2].stoppedSlot == 0) 

            prizeValue = "ไก่";

        else if (rows[0].stoppedSlot == 1 
            && rows[1].stoppedSlot == 1 
            && rows[2].stoppedSlot == 1)

            prizeValue = "นกฮูก";

        else if (rows[0].stoppedSlot == 2 
            && rows[1].stoppedSlot == 2 
            && rows[2].stoppedSlot == 2) 

            prizeValue = "จิ้งจอก"; 

        else if (rows[0].stoppedSlot == 3 
            && rows[1].stoppedSlot == 3 
            && rows [2].stoppedSlot == 3)

            prizeValue = "ผีเสื้อ";
        
        else if (rows[0].stoppedSlot == 4 
            && rows[1].stoppedSlot == 4 
            && rows [2].stoppedSlot == 4)

            prizeValue = "แมว";

        else if (rows[0].stoppedSlot == 5 
            && rows[1].stoppedSlot == 5 
            && rows [2].stoppedSlot == 5)

            prizeValue = "ปลาวาฬ";
        
        else if (rows[0].stoppedSlot == "ปู" 
            && rows[1].stoppedSlot == "ปู" 
            && rows [2].stoppedSlot == "ปู")

            prizeValue = "ปู";

        else if (rows[0].stoppedSlot == "เต่า" 
            && rows[1].stoppedSlot == "เต่า" 
            && rows [2].stoppedSlot == "เต่า")

            prizeValue = "เต่า";

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == 0))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == 0))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == 0)))

            prizeValue = "ไก่";

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == 1))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == 1))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == 1)))

            prizeValue = "นกฮูก";
        
        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == 2))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == 2))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == 2)))

            prizeValue = "จิ้งจอก";
        
        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == 3))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == 3))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == 3)))

            prizeValue = "ผีเสื้อ";
        
        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == 4))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == 4))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == 4)))

            prizeValue = "แมว";

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == 5))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == 5))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == 5)))

            prizeValue = "ปลาวาฬ";

        else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
            && (rows[0].stoppedSlot == "ปู"))

            || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[0].stoppedSlot == "ปู"))

            || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
            && (rows[1].stoppedSlot == "ปู")))

            prizeValue = "ปู";

        resultsChecked = true;
    }
    */

    // private void CheckResults()
    // {
    //     if (rows[0].stoppedSlot == "ไก่" 
    //         && rows[1].stoppedSlot == "ไก่" 
    //         && rows[2].stoppedSlot == "ไก่") 

    //         prizeValue = "ไก่";

    //     else if (rows[0].stoppedSlot == "นกฮูก" 
    //         && rows[1].stoppedSlot == "นกฮูก" 
    //         && rows[2].stoppedSlot == "นกฮูก")

    //         prizeValue = "นกฮูก";

    //     else if (rows[0].stoppedSlot == "จิ้งจอก" 
    //         && rows[1].stoppedSlot == "จิ้งจอก" 
    //         && rows[2].stoppedSlot == "จิ้งจอก") 

    //         prizeValue = "จิ้งจอก"; 

    //     else if (rows[0].stoppedSlot == "ผีเสื้อ" 
    //         && rows[1].stoppedSlot == "ผีเสื้อ" 
    //         && rows [2].stoppedSlot == "ผีเสื้อ")

    //         prizeValue = "ผีเสื้อ";
        
    //     else if (rows[0].stoppedSlot == "แมว" 
    //         && rows[1].stoppedSlot == "แมว" 
    //         && rows [2].stoppedSlot == "แมว")

    //         prizeValue = "แมว";

    //     else if (rows[0].stoppedSlot == "ปลาวาฬ" 
    //         && rows[1].stoppedSlot == "ปลาวาฬ" 
    //         && rows [2].stoppedSlot == "ปลาวาฬ")

    //         prizeValue = "ปลาวาฬ";
        
    //     else if (rows[0].stoppedSlot == "ปู" 
    //         && rows[1].stoppedSlot == "ปู" 
    //         && rows [2].stoppedSlot == "ปู")

    //         prizeValue = "ปู";

    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ไก่"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ไก่"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "ไก่")))

    //         prizeValue = "ไก่";

    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "นกฮูก"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "นกฮูก"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "นกฮูก")))

    //         prizeValue = "นกฮูก";
        
    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "จิ้งจอก"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "จิ้งจอก"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "จิ้งจอก")))

    //         prizeValue = "จิ้งจอก";
        
    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ผีเสื้อ"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ผีเสื้อ"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "ผีเสื้อ")))

    //         prizeValue = "ผีเสื้อ";
        
    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "แมว"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "แมว"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "แมว")))

    //         prizeValue = "แมว";

    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ปลาวาฬ"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ปลาวาฬ"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "ปลาวาฬ")))

    //         prizeValue = "ปลาวาฬ";

    //     else if (((rows[0].stoppedSlot == rows[1].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ปู"))

    //         || ((rows[0].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[0].stoppedSlot == "ปู"))

    //         || ((rows[1].stoppedSlot == rows[2].stoppedSlot) 
    //         && (rows[1].stoppedSlot == "ปู")))

    //         prizeValue = "ปู";

    //     resultsChecked = true;
    // }
       IEnumerator ExampleCoroutine()
    {
       
        yield return new WaitForSeconds(20);

   
    }
}