using UnityEngine;
using System.Collections;

public class MainGameController : MonoBehaviour {
    public int frame = 0;
	// Use this for initialization
	void Start () {
        Instantiate(Resources.Load("Prefabs/Ghost"));
	}
	
	// Update is called once per frame
	void Update () {
        frame += 1;
        if (frame % 300 == 0)
        {
            Instantiate(Resources.Load("Prefabs/Ghost"));
        }
	
	}
}
