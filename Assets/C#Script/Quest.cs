        // using System.Collections;
        // using System.Collections.Generic;
        // using UnityEngine;

        // public class Quest : ScriptableObject
        // {
        // [System.Serializable]

        // public struct Info 
        // {
        //     public string Name;
        //     public Sprite Icon;
        //     public string Description;

        // }
        // [Header("Info")] public Info information;

        // [System.Serializable]

        // public struct Stat
        // {
        //     public int Currency;
        //     public int XP;
        // }
        //     [Header("Reward")] public Stat Reward = new Stat {Currency = 10, XP = 10};

        //     public bool Completed {get; protected set;}
        //     public QuestCompletedEvent QuestCompleted;

        //     public abstract class QuestGoal : ScriptableObject
        //     {
        //         protected string Description;
        //         public int CurrentAmount {get; protected set;}
        //         public int RequireAmount = 1;

        //         public bool Completed {get; protected set;}
        //         [HideInInspect] public UnityEvent GoalCompleted;
        //         public virtual string GetDescription(){
        //             return Description;
        //         }
        //         public virtual void Initialize(){
        //             Completed = false;
        //             GoalCompleted = 
        //         }
        //         protected void Evaluate(){
        //             if(CurrentAmount >= RequiredAmount){
        //                 Complete();
        //             }
        //         }

        //         private void Complete(){
        //             Completed = true;
        //             GoalCompleted.Invoke();
        //             GoalCompleted.RemoveAllListeners();
        //         }

        //         public void Skip(){
        //             Complete();
        //         }
        //         public List<QuestGoal> Goals;

        //         public void Initialize(){
        //             Completed = false;
        //             QuestCompleted = new QuestCompletedEvent();

        //             foreach (var VARIABLE:QuestGoal in Goals){
        //                 goal.Initialize();
        //                 goal.GoalCompleted.AddListener(delegate { CheckGoals();});
        //             }
        //         }
        //         private void CheckGoals(){
        //             Completed = Goals.All(g => g.Completed);
        //             if(Completed){
        //                 QuestCompleted.Invoke(this);
        //                 QuestCompleted.RemoveAllListeners();
        //             }
        //         }
        //     }
        //     public class QuestCompletedEvent : UnityEngine<Quest> {

        //     }
        // }
