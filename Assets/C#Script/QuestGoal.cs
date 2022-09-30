using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal 
{
   public GoalType goalType;

   public int requiredAmount;
   public int currentAmount;

   public bool IsReached(){

    return (currentAmount >= requiredAmount);
   }

   public void Buy(){

    if(goalType == GoalType.Buy)
    currentAmount++;
   }

    public void Deposite(){

    if(goalType == GoalType.Deposite)
    currentAmount++;
   }
    public void Withdraw(){

    if(goalType == GoalType.Withdraw)
    currentAmount++;
   }
    public void Pay(){

    if(goalType == GoalType.Pay)
    currentAmount++;
   }
    public void Work(){

    if(goalType == GoalType.Work)
    currentAmount++;
   }
    public void Relax(){

    if(goalType == GoalType.Relax)
    currentAmount++;
   }
    public void ShoppingMarket(){

    if(goalType == GoalType.ShoppingMarket)
    currentAmount++;
   }
    public void Temple(){

    if(goalType == GoalType.Temple)
    currentAmount++;
   }
 
}
public enum GoalType{
    Buy,Deposite,Withdraw,Pay,Work,
    Relax,ShoppingMarket,Temple
}