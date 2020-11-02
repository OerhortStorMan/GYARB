using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int cubesOnBoard = 0;
   
    private void OnTriggerEnter(Collider other) {
        cubesOnBoard++;
         Debug.Log(cubesOnBoard);
    }
    private void OnTriggerExit(Collider other) {
        cubesOnBoard--;
    }
}
