using UnityEngine;
using System.Collections;

public class GhostsController : MonoBehaviour {
    public GameObject TargetPlayer;
    public int hp = 60;
    public GameObject BarCol;
    public GameObject Player;
    public Collider barcol;
    public Collider playercol;
	// Use this for initialization
	void Start () {
        TargetPlayer = GameObject.Find("Player");
        Player = GameObject.Find("Player");
        BarCol = GameObject.Find("Player/BarCollider");
        transform.LookAt(TargetPlayer.transform);	
        barcol=BarCol.GetComponent<Collider>();
        playercol=Player.GetComponent<Collider>();
//        float initangel=Unity.Random.Range(0.0f,360f);
//        transform.position
	}
	
	// Update is called once per frame
	void Update () {
        FollowPlayer();
        if(hp<=0){
            Destroy(gameObject);
        }
	
	}
    void FollowPlayer()
    {
        transform.LookAt(TargetPlayer.transform);
        transform.Translate(Vector3.forward * 0.02f);

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "BarCollider")
        {
            hp -= 1;
        }
    }
    void OnTriggerEnter(Collider other){
        Debug.Log(other.gameObject);
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
