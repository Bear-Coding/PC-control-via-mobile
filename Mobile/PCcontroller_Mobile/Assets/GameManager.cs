using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeTag(GameObject go)
    {
        if (go.tag == "Clicked") go.tag = "Untagged";
        else go.tag = "Clicked";
            
    }
}
