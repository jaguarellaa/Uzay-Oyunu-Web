using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController: MonoBehaviour
{
    public ParticleSystem UfoEgzost1, UfoEgzost2, UfoEgzost3;
    public void SetPlayDelay()
    {

        
       

        

        UfoEgzost1.Play();
        UfoEgzost2.Play();
        UfoEgzost3.Play();



    }


    public void SetStopDelay()
    {

      
        UfoEgzost1.Stop();
        UfoEgzost2.Stop();
        UfoEgzost3.Stop();







    }
}
