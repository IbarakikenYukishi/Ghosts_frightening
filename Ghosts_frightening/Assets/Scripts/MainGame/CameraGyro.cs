using UnityEngine;
using System.Collections;

public class CameraGyro : MonoBehaviour {
    private Vector3 rot;
    public bool VRFlag;
	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
        rot = transform.rotation.eulerAngles;
        VRFlag = GameStartController.GetVRFlag();
        Debug.Log(VRFlag);
	}
	
	// Update is called once per frame
	void Update () {
        float spd = Time.deltaTime * 100.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rot.y -= spd;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rot.y += spd;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rot.x -= spd;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rot.x += spd;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * 0.3f;
        }
//        rot.y += 10.0f;
        transform.rotation = Quaternion.Euler(rot);
        if(VRFlag)transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180.0f, Vector3.forward);
    }
}
