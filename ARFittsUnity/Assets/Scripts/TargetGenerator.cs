using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using extendedtargets;


public class TargetGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject targetBall = null;
    private int[] theta1Arr = new int[]{0, 30, 60, 90};
    private int[] theta2Arr = new int[]{0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330};
    public int RADIUS = 5;
 
    private int NUM_OF_TARGETS = 37;
    private Target [] targets = new Target[37]; 
    HashSet<int> targetIDs = new HashSet<int>();

    float getX(int theta, int r)
    {
        float x =  (float)(r * Math.Cos(theta));
        return x;
    }

   float getY(int theta, int r)
    {
        float y =  (float)(r * Math.Sin(theta));
        return y;
    }

    float getZ(int theta, int r)
    {
        float z =  (float)(r * Math.Sin(theta));
        return z;
    } 

    void setRandomSet()
    {  
        System.Random rnd = new System.Random();
        
        for (int i = 0; i < NUM_OF_TARGETS; i++) 
        {
            while (!targetIDs.Add(rnd.Next(0,NUM_OF_TARGETS)));
        }
        
    }

    public void initTargetsArr()
    {

       int id = 0;
        for(int i =0; i < theta1Arr.Length; i++){
            for(int j=0; j < theta2Arr.Length; j++){
                
       
                targets[id] = new Target(id, theta1Arr[i], theta2Arr[j]);

                //later change this to inside targets class
                float x = getX(theta2Arr[j], RADIUS);
                float y = getY(theta1Arr[i], RADIUS);
                float z = getZ(theta2Arr[j], RADIUS);
                targets[id].x = x;
                targets[id].y = y;
                targets[id].z = z;
                id++;
                Debug.Log("id is: "+id.ToString());
                if(theta1Arr[i] == 90){break;}
            }
        } 
    }


    void setTargetsPosition(Target[] tarray, Material targetColor)
    {

    }

    void Start()
    {
        setRandomSet();
        initTargetsArr();
    
        GameObject target = Instantiate(
        targetBall,
        transform.position + new Vector3(targets[0].x ,targets[0].y, targets[0].z),
        Quaternion.Euler(0, 0, 0)
        );
        //Debug.Log(getX(30,5).ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onStartPressed () {
        
    }
}