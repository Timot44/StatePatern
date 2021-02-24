
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


public class Context : MonoBehaviour
{
   
    private State currentState;
    [SerializeField]
    private int _itération;
    [SerializeField]
    private float timer = 5f;


    
    
    public Context()
    {
        currentState = new VoiesDisponible();
        
    }

    public void NextState(State state)
    {
        currentState = state;
    }

    async Task Timer()
    {
        await new WaitForSeconds(2f);
        Debug.Log("Un Train repart");
        Gare(1);
       
    }

    public void Gare(int itération)
    {
     
        for (int i = 0; i < itération; i++)
        {
          int train = Random.Range(0, 2);
          if (train == 1)
          {
              currentState.TrainArrive(this);
          }

          else
           {
                currentState.TrainGoes(this); 
           }
        }
       
      
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timer = Mathf.Clamp(timer, 0, Mathf.Infinity);
    }

    async void StartWaitingTrain()
    {
        await new WaitUntil((() => timer <= 0f));
        Debug.Log("New train");
        Timer();
    }

    public void Start()
    {
        Gare(_itération);
        StartWaitingTrain();
    }
}
