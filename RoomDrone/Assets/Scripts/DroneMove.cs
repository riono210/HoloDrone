using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour {

    public GameObject drone;
    [HideInInspector] 
    public Rigidbody droneRb;

    public int speed;

	// Use this for initialization
	void Start () {
        droneRb = drone.GetComponent<Rigidbody>();
        if(droneRb == null){
            Debug.Log("riなし");
        }
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        // Joy-Con(R)
        //var h1 = Input.GetAxis("Horizontal 1");
        //var v1 = Input.GetAxis("Vertical 1");
        //Debug.Log("h1:" + h1 + " v1:" + v1);


        //// Joy-Con(L)
        //var h2 = Input.GetAxis("Horizontal 2");
        //var v2 = Input.GetAxis("Vertical 2");
        //Debug.Log("h2:" + h2 + " v2:" + v2);
        DroneMover();

    }

    void DroneMover(){
        bool left;
        bool right;
        bool forwart;
        bool back;

        float xAxis = 0;
        float yAxis = 0;

        if (Input.GetKey(KeyCode.LeftArrow)){
            //droneRb.AddForce(Vector3.left * speed);
            xAxis = -speed;
            left = true;
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            //droneRb.AddForce(Vector3.right * speed);
            xAxis = speed;
            right = true;
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            //droneRb.AddForce(Vector3.forward * speed);
            yAxis = speed;
            forwart = true;
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            //droneRb.AddForce(Vector3.back * speed);
            yAxis = -speed;
            back = true;
        }

        droneRb.AddForce(Vector3.right * xAxis + Vector3.forward * yAxis);

        Debug.Log(droneRb.velocity);


    }
}
