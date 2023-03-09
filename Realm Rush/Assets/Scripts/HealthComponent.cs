using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{

    [SerializeField] int MaxHit = 4 ;

    [SerializeField] int CurrentHit = 0 ;

    void Start()
    {
        CurrentHit = MaxHit ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject other){
        //ProcessHit();
        Debug.Log("dawdawdawd");
    }
    // void ProcessHit(){
    //     CurrentHit--;
    //     if(CurrentHit <= 0){
            
    //     }
    // }
}
