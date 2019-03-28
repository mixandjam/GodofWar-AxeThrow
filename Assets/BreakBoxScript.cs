using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBoxScript : MonoBehaviour
{

    public GameObject breakedBox;

    public void Break()
    {
        GameObject breaked = Instantiate(breakedBox, transform.position, transform.rotation);
        Rigidbody[] rbs = breaked.GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rb in rbs)
        {
            rb.AddExplosionForce(150, transform.position, 30);
        }
        Destroy(gameObject);
    }
}
