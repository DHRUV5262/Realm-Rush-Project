using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMover : MonoBehaviour
{

    [SerializeField] List<WayPoint> path = new List<WayPoint>();
    [SerializeField] [Range(1,5)] float Speed =1f ;
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach(WayPoint i in path)
        {
            Vector3 Start = transform.position ;
            Vector3 end = i.transform.position ;
            float TravelPercent = 0 ;
            transform.LookAt(end);
            while(TravelPercent<1){
                TravelPercent += Time.deltaTime * Speed ;
                transform.position = Vector3.Lerp(Start,end,TravelPercent);//Lerp is for Smooth Movement
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
