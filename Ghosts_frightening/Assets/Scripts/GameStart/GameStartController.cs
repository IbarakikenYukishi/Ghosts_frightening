using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStartController : MonoBehaviour {
    public static bool VRFlag = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public static bool GetVRFlag()
    {
        return VRFlag;
    }
    public void GF_Change_MainGame()
    {
        VRFlag = true;
        Application.LoadLevel("MainGame");
    }
    public void GF_Change_DebugMode()
    {
        VRFlag = false;
        Application.LoadLevel("MainGame");
    }
}
