using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonball;
    public float shootForce;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = (GameObject)Instantiate(cannonball,transform.position,transform.rotation);
            
            projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
        }
    }
}
