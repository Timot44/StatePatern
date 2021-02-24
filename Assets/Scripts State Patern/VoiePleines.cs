using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiePleines : State
{
    public override void TrainGoes(Context ctx)
    {
        Debug.Log(train);
        if (train >= 1)
            {
                trainEvent.RemoveAllListeners();
                trainEvent.AddListener(FreeCall);
                trainEvent.Invoke();
                Debug.Log("Un train part mais un autre arrive");
            }
        else if (train < 1)
        {
            train--; 
            Debug.Log("un train part et il n'y en avait pas en attente");
            ctx.NextState(new VoiesLibre());
        }
            
        
    }


    public override void TrainArrive(Context ctx)
    {
       
        train++;
        Debug.Log("la gare est pleine, le train pars en attente");
        
    }
}
