using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimations : MonoBehaviour {

    public float timeRemaining = 7.5f;
 
     // Use this for initialization
     void Start () {
 
     }
     
     void Update ()
     {
         // Functional game countdown timer
         timeRemaining -= Time.deltaTime;
         if (timeRemaining > 0) 
         {
         }
            else 
         {
            Destroy(gameObject);
         }
     }
}