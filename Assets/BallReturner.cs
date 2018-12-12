using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReturner : MonoBehaviour {

    public GameObject golfBall;
    public Transform spawnPos1, spawnPos2; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hole1"))
        {
            Instantiate(golfBall, spawnPos1.position, Quaternion.identity); 
        }

        if (other.gameObject.CompareTag("Hole2"))
        {
            Instantiate(golfBall, spawnPos2.position, Quaternion.identity);
        }
    }
}
