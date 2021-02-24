using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiesLibre : State
{
   
    public override void TrainGoes(Context ctx)
    {
        train--;
        trainEvent.AddListener(EventCall);
        trainEvent.Invoke();
        ctx.NextState(new VoiesDisponible());
    }

    public override void TrainArrive(Context ctx)
    {
        train++;
        Debug.Log("Le Deuxième rentre dans la gare");
        
        ctx.NextState(new VoiePleines());
        
    }

    
  
}
