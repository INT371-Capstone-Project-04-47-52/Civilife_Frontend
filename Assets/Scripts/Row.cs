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
            if (transform.position.y <= -3.5f)
            transform.position = new Vector2(transform.position.x, 1.75f);

            transform.position = new Vector2(transform.position.x, transform.position.y - 0.25f);

            yield return new WaitForSeconds(timeInterval);
        }

        randomValue = Random.Range(85,100);

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
            if (transform.position.y <= -6f) 
                transform.position= new Vector2 (transform.position.x, 6f);
                
            transform.position= new Vector2 (transform.position.x, transform.position.y - 1.5f);

            if (i > Mathf.RoundToInt(randomValue * 0.25f))
                timeInterval = 0.05f; 
            if (i > Mathf.RoundToInt(randomValue * 0.5f)) 
                timeInterval = 0.1f;
            if (i > Mathf.RoundToInt(randomValue * 0.75f)) 
                timeInterval = 0.15f;
            if (i > Mathf.RoundToInt(randomValue * 0.95f)) 
                timeInterval = 0.2f;

            yield return new WaitForSeconds (timeInterval); 
            
            if (transform.position.y == -6f)
                stoppedSlot = "Diamond"; 
            else if (transform.position.y == -4.5f) 
                stoppedSlot = "Crown"; 
            else if (transform.position.y == -3f)
                stoppedSlot = "Melon";
            else if (transform.position.y == -1.5f)
                stoppedSlot = "Bar"; 
            else if (transform.position.y == 0f)
                stoppedSlot = "Seven"; 
            else if (transform.position.y == 1.5f)
                stoppedSlot = "Cherry"; 
            else if (transform.position.y == 3f)
                stoppedSlot = "Lemon"; 
            else if (transform.position.y == 6f)
                stoppedSlot = "Diamond"; 

            rowStopped = true;
        }
        
    }
    private void OnDestroy()
        {
            GameControl.HandlePulled -= StartRotating;
        }
}
