using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCommand : MonoBehaviour {

    string URL = "server/connection.php";
    //public string Inputid, Inputcommand;
    public GameObject[] btn;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < btn.Length; i++)
        {
            if (btn[i].tag == "Clicked")
            {
                SendCmd(i+1+"");
                btn[i].tag = "Untagged";
            }
        }
 
        
    }
    public void SendCmd(string cmd)
    {
        WWWForm form = new WWWForm();
       // form.AddField("addID", id);
        form.AddField("addCMD", cmd);

        WWW www = new WWW(URL, form);
    }
}
