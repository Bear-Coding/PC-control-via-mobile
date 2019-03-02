using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userSelect : MonoBehaviour {

    readonly string URL = "tamernasser.com/userSelect.php";
    public string[] usersData;
    // Use this for initialization
    IEnumerator Start () {
        Debug.Log(URL);
        WWW users = new WWW(URL);
        yield return users;
        Debug.Log(users);
        string usersDataString = users.text;
        usersData = usersDataString.Split(';');

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
