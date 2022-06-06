using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSurfacesControl : MonoBehaviour
{
    public Texture2D tex;
    public Transform rightElevator, leftElevator;
    public Transform rightFlap, leftFlap;
    public Transform rightRudder, leftRudder;
    public float MRx, MRy, MRz;
    public float maxAngle, flapMaxAngle, rudderMaxAngle;
    public float rightElevatorSetAngle, leftElevatorSetAngle;
    public bool useMouse;
    public bool turnFlap;
    private bool f;
    public float turnSpeed;
    private float angleX;
    // 작성
    public float pitchAmount;
    public float yawAmount;
    public float rollAmount;
    public float speed;
    public GameObject proppeler;
    public bool iTrue;

    Vector3 rotateValue;
	// Use this for initialization
	void Start () {
        iTrue = true;
		turnSpeed = 300;
	}
	
	// Update is called once per frame
	void Update () {
        MoveAircraft();
        MRx = Input.GetAxis("Vertical");
        MRy = Input.GetAxis("Horizontal");
        MRz = Input.GetAxis("Yaw");
        proppeler.transform.Rotate(new Vector3(0, turnSpeed * Time.deltaTime, 0));
    }
    void MoveAircraft(){
        rotateValue = new Vector3(-MRx * pitchAmount, 
                                MRy * yawAmount, 
                                MRz * rollAmount);                              
        transform.Rotate(rotateValue * Time.deltaTime);
        transform.Translate(new Vector3(0,0,speed));
    }   
}

