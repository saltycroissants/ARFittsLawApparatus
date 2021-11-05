using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace extendedtargets{
    public class Target
{
    // Start is called before the first frame update
    public int targetID{get;}
    //public GameObject targetObj{get; set;}
    public int theta1 {get;}
    public int theta2 {get;}
    public float x {get; set;}
    public float y{get; set;}
    public float z {get; set;}
    public Target(int atargetID, int atheta1, int atheta2){
        targetID = atargetID;
        theta1 = atheta1;
        theta2 = atheta2;
    }
}
}
