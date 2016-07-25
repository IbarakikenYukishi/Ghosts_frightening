using UnityEngine;
using System.Collections;

public class ClockController : MonoBehaviour {
    AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
    void Clock_AddRigidbody()
    {
        gameObject.AddComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {
        audio.Play();
        Destroy(GetComponent("Rigidbody"));
    }
}
