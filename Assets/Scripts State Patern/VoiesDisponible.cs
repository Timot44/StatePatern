using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiesDisponible : State
{
  
  
    public VoiesDisponible()
    {
        
    }


    public override void TrainGoes(Context ctx)
    {
        
        Debug.Log("Il y a aucun train qui part car la voie est libre");

    }

    public override void TrainArrive(Context ctx)
    {
       
        train++;
        ctx.NextState(new VoiesLibre());
        Debug.Log("Le Train arrive dans la gare");
    }
}
