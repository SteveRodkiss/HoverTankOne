using UnityEngine;
using System.Collections;

public class Camerafollow : MonoBehaviour
{

    public GameObject Target;
    public Vector3 Offset = new Vector3(0, 5, -20);
    	
    // Update is called once per frame
    void Update()
    {
        Vector3 TransformedOffset = Target.transform.TransformPoint(Offset);
        transform.position = TransformedOffset;
        transform.LookAt(Target.transform);
    }
}
