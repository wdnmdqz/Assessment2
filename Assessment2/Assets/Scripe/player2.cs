using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{   public float cooltime=3;
    private float time;
    private int speed=2;
    
    void Start()
    {
        
    }
    
    
    void Update()
    {
       
        float h = Input.GetAxis(InputAxes.MoveH);
        float v = Input.GetAxis(InputAxes.MoveV);
        transform.Translate(new Vector3(h, 0, v) *speed* Time.deltaTime,Space.World);
        transform.rotation = Quaternion.LookRotation(new Vector3(h, 0, v));
        
        
      
        
       
    }
}