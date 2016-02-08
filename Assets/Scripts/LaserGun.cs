using UnityEngine;
using System.Collections;

public class LaserGun : MonoBehaviour
{

    public GameObject Laser;
    //fire rate of bullet
    public float FireRate = 10f;
    float Delay = 1f;
    float Timer = 0f;

    void Start()
    {
        Delay = 1f / FireRate;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && Timer >= Delay)
        {
            Timer = 0f;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(Laser, transform.position, transform.rotation);
    }
}
