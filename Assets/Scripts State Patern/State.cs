using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class State
{
 protected int train = 1;
 public UnityEvent trainEvent = new UnityEvent();
 public State()
 {
  
 }

 public virtual void TrainArrive(Context ctx)
 {
 }

 public virtual void TrainGoes(Context ctx)
 {
  
 }

 protected void EventCall()
 {
  Debug.Log("Le train part de la gare");
 }

 protected void FreeCall()
 {
  Debug.Log("Une place se libère");
 }
}
