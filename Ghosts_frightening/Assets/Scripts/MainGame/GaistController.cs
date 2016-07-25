using UnityEngine;
using System.Collections;

public class GaistController : MonoBehaviour {
    public int hp = 150;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            GameObject Clock = GameObject.Find("clock");
            Clock.SendMessage("Clock_AddRigidbody");
            Destroy(gameObject);
        }

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "BarCollider")
        {
//            Debug.Log("BarColEntered");
            hp -= 1;
        }
//        Debug.Log("Entered");
    }
}
