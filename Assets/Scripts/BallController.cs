using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public Rigidbody ballBody;
    public bool movingLeft, movingRight = false;
    public float speed = 1f;
    // Use this for initialization
    void Start () {
        ballBody = gameObject.GetComponent<Rigidbody>();
        ballBody.isKinematic = true;
	}

    public void ReleaseBall()
    {
        ballBody.isKinematic = false;
    }
    public void StopBall()
    {
        ballBody.isKinematic = false;
    }

    public void MoveLeft()
    {
        ballBody.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
    }
    public void MoveRight()
    {
        ballBody.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update ()
    {
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Pin")
        {
            ballBody.AddExplosionForce(200f, transform.position, 10f);
        }
    }
}
