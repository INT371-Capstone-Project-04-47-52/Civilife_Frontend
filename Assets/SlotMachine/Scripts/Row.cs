using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour 
{
    private int randomValue;
    private float timeInterval;

    public bool rowStopped;
    public string stoppedSlot;

    // Use this for initialization
    void Start()
    {
        rowStopped = true;
        GameControl.HandlePulled += StartRotating;
    }

    private void StartRotating()
    {
        stoppedSlot = "";
        StartCoroutine("Rotate");
    }

    private IEnumerator Rotate()
    {
        rowStopped = false;
        timeInterval = 0.025f;

        for (int i = 0; i < 30; i++)
        {
            if (transform.position.y <= -540f)
            transform.position = new Vector2(transform.position.x, -155f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);
        }

        randomValue = Random.Range(0,100);

        switch (randomValue % 3)
        {
            case 1:
                randomValue += 2;
                break;
            case 2:
                randomValue += 1;
                break;
        }

        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= -540f) 
                transform.position= new Vector2 (transform.position.x, -155f);
                
            transform.position= new Vector2 (transform.position.x, transform.position.y - 55f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f; 
            if (i > Mathf.RoundToInt(randomValue * 0.5f)) 
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 0.75f)) 
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 0.95f)) 
                timeInterval = 0.2f;

            yield return new WaitForSeconds (timeInterval); 
            
            if (transform.position.y == -540f)
                stoppedSlot = "ไก่"; 
            else if (transform.position.y == -485f) 
                stoppedSlot = "นกฮูก"; 
            else if (transform.position.y == -430f)
                stoppedSlot = "จิ้งจอก";
            else if (transform.position.y == -375f)
                stoppedSlot = "ผีเสื้อ"; 
            else if (transform.position.y == -320f)
                stoppedSlot = "แมว"; 
            else if (transform.position.y == -265f)
                stoppedSlot = "ปลาวาฬ"; 
            else if (transform.position.y == -210f)
                stoppedSlot = "ปู"; 
            else if (transform.position.y == -155f)
                stoppedSlot = "เต่า"; 

            rowStopped = true;
        }
/*
        for (int i = 0; i < randomValue; i++)
        {
            if (transform.position.y <= -540f) 
                transform.position= new Vector2 (transform.position.x, -155f);
                
            transform.position= new Vector2 (transform.position.x, transform.position.y - 55f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f; 
            if (i > Mathf.RoundToInt(randomValue * 0.5f)) 
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 0.75f)) 
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 0.95f)) 
                timeInterval = 0.2f;

            yield return new WaitForSeconds (timeInterval); 
            
            if (transform.position.y == -540f)
                stoppedSlot = 0; 
            else if (transform.position.y == -485f) 
                stoppedSlot = 1; 
            else if (transform.position.y == -430f)
                stoppedSlot = 2;
            else if (transform.position.y == -375f)
                stoppedSlot = 3; 
            else if (transform.position.y == -320f)
                stoppedSlot = 4; 
            else if (transform.position.y == -265f)
                stoppedSlot = 5; 
            else if (transform.position.y == -210f)
                stoppedSlot = 6; 
            else if (transform.position.y == -155f)
                stoppedSlot = 7; 

            rowStopped = true;
        }
        */
    }
    
    private void OnDestroy()
        {
            GameControl.HandlePulled -= StartRotating;
        }
}
