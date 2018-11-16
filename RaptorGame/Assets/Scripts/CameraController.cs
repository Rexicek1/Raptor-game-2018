using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject player;
    public float cameraHeight = 20.0f;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        gameObject.transform.rotation = Quaternion.identity;
        gameObject.transform.Rotate(new Vector3(90, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = player.transform.position;
        pos.y += cameraHeight;
        transform.position = pos;
    }
}
