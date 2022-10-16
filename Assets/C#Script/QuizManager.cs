using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
   public List<QuestionAndAnswer> QnA;
   public GameObject[] options;
   public int currentQuestion;
   public GameObject QuizPanel;
//    public GameObject GoPanel;
   public TMP_Text QuestionTXT;

   public GameObject WorkList;
//    public TMP_Text ScoreTXT;
   int totalQuestions = 0;
    public int score;


    
   private void Start(){
    totalQuestions = QnA.Count;
    
    // GoPanel.SetActive(false);
        generateQuestion();

            
   }
//    public void retry(){

//    }
    // public void GameOver(){
    //     if(totalQuestions==2){
    //              QuizPanel.SetActive(false);
    //     // GoPanel.SetActive(true);
    //     }
   
    //     // ScoreTXT.text = score + " /" + totalQuestions;
    // }
    public void correct(){
        score +=1;

          QnA.RemoveAt(currentQuestion);
        StartCoroutine(WaitForNext());

        
    }
    public void wrong(){
       QnA.RemoveAt(currentQuestion);
         StartCoroutine(WaitForNext());

    }
   void SetAnswers(){
        for(int i = 0; i<options.Length; i++)
        {   
            options[i].GetComponent<AnswerScripts>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];
            options[i].GetComponent<Image>().color = options [i].GetComponent <AnswerScripts>().startColor;
       
        if(QnA[currentQuestion].CorrectAnswer == i+1){
            options[i].GetComponent<AnswerScripts>().isCorrect = true;
            options [i].GetComponent<Image>().color = options [i].GetComponent <AnswerScripts>().startColor;
        }
       
        }
       
   }
     IEnumerator WaitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }
   void generateQuestion(){
    if(QnA.Count >0 ){
         currentQuestion = UnityEngine.Random.Range(0, QnA.Count);

         QuestionTXT.text = QnA[currentQuestion].Question;
         SetAnswers();   

          if(totalQuestions==2){
                 QuizPanel.SetActive(false);
                 WorkList.SetActive(true);

        // GoPanel.SetActive(true);
        }
    }
    else{
        Debug.Log("Out of Question");
        QuizPanel.SetActive(false);

        
    }


  
   }


}
