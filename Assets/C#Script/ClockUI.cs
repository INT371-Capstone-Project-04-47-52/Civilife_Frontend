// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class ClockUI : MonoBehaviour
// {   private const float REAL_SECONDS_PER_INGAME_DAY = 60f;
//     private Transform clockMinuteHandTransform;
//     private Transform clockHourHandTransform;
//     private float day;
//     private Text timeTXT;
//     private void Awake(){
         
//         clockHourHandTransform = transform.Find("hourHand");
//         clockMinuteHandTransform = transform.Find("minuteHand");
//         timeTXT = transform.Find("TimeTXT").GetComponent<Text>();
    
    
//     }
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {   day+= 7 / 90;
//         float dayNormalized = day % 1f;
//         float rotationDegreesPerDay = 360f;
//         clockHourHandTransform.eulerAngles = new Vector3(0,0, -dayNormalized * rotationDegreesPerDay);
//         float hoursPerDay = 24f;
//         clockMinuteHandTransform.eulerAngles = new Vector3(0,0, -dayNormalized * rotationDegreesPerDay * hoursPerDay);

//         string hoursString = Mathf.Floor(dayNormalized * 24f).ToString("00");
//         float minutesPerHour = 60f;
//         string minuteString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");

//         timeTXT.text = hoursString + ":" + minuteString;
//     }
// }
