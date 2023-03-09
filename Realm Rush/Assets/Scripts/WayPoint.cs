using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{

    [SerializeField] GameObject Tower ;
    [SerializeField] bool Flag ;
    bool full = true;

    Vector3 z = new Vector3(0,1.8f,0);
    void OnMouseDown(){
        if(Flag && full){
            Instantiate(Tower,transform.position + z , Quaternion.identity);
            full = false ;
        }
    }
}
