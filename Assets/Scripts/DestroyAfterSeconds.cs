using UnityEngine;
using System.Collections;

public class DestroyAfterSeconds : MonoBehaviour
{
    public float Seconds = 1f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, Seconds);
    }
}
