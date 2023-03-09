using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro ;


[ExecuteAlways]
public class CorrdinateLabler : MonoBehaviour
{

    TextMeshPro label ;

    Vector2Int c= new Vector2Int();

    void Awake(){

        label = GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying){
            DisplayCoordinates();
            UpdateName();
        }
    }

    void DisplayCoordinates(){

        c.x = Mathf.RoundToInt(transform.parent.position.x );
        c.y = Mathf.RoundToInt(transform.parent.position.z );
        label.text = c.x + "," + c.y;
    }

    void UpdateName(){
        transform.parent.name = c.ToString();
    }
}
