using UnityEngine;
using System.Collections;

//Spaceship flight controls
public class SpaceShipControl : MonoBehaviour
{
    float Thrust = 5000f;
    float TurnForce = 1000f;
    float PitchForce = 5000f;
    Rigidbody rb;

    //these values use to calculate pitch and bank of the spaceship mesh
    public float maxturnrate = 2f;
    public float maxclimbrate = 20f;

    //the mesh gets rotated to simulate banking
    public Transform mesh;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

 

    void FixedUpdate()
    {
        //input for the pitch
        float pitch = Input.GetAxis("Vertical");
        rb.AddRelativeForce(new Vector3(0, pitch * PitchForce, 0));

        //now the turn-- y rotation only! x and z are frozen in the rigidbody constraints
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(new Vector3(0, turn * TurnForce, 0));

        //thrust
        rb.AddRelativeForce(new Vector3(0, 0, Thrust));

        //now pitch and roll of mesh
        float turnvalue = (rb.angularVelocity.y / maxturnrate) * -90f;
        float pitchvalue = (rb.velocity.y / maxclimbrate) * -30f;
        //rotate the lower level mesh to simulate the banking and pitching
        Quaternion rotation = Quaternion.Euler(pitchvalue, 0, turnvalue);
        mesh.localRotation = rotation;
    }





}
