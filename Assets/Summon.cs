using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; 

public class Summon : MonoBehaviour {

    public Transform summonPos; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (SteamVR_Input._default.inActions.TouchPadPress.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            //print("Touch Pad Press");
            this.transform.position = summonPos.position;
            this.transform.localEulerAngles = Camera.main.transform.localEulerAngles; 
            GetComponent<Rigidbody>().isKinematic = true; 
        }
	}

    public void TurnOffKinematic()
    {
        GetComponent<Rigidbody>().isKinematic = false;

    }
}
