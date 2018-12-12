using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientSnap : MonoBehaviour {


    bool hasParent = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (this.transform.parent != null && !hasParent)
        {
            print("I have been parented");
            hasParent = true; 
        }

        if (this.transform.parent == null && hasParent)
        {
            print("I no long have a parent");
            hasParent = false; 
        }
	}

    public void OrientToHand()
    {

        print("I was attached, now orienting"); 
       
    }
}
