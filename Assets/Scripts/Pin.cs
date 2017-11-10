using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
    public GameObject collideParticle;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Instantiate(collideParticle, transform.position, transform.rotation);
            //coll.gameObject.GetComponent<Rigidbody>().AddExplosionForce(200f, coll.transform.position, 10f);
        }
    }
}
