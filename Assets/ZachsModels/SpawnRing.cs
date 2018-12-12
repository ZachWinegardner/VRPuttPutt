using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRing : MonoBehaviour {


    public GameObject ring;
    Vector3 startPos;
    public bool hasHitGround = false; 

	// Use this for initialization
	void Start () {
        startPos = this.transform.position;
       // ring = this.gameObject; 
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && !hasHitGround)
        {
            Instantiate(ring, startPos, Quaternion.identity);
            //print("spawing");
            hasHitGround = true; 
           // this.GetComponent<SpawnRing>().enabled = false; 
        }
    }
}
