using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
    public Rigidbody ballBody;
    public bool movingLeft, movingRight = false;
    public int life = 1;
    public float speed = 1f;

    private int score;
    private Text scoreTxt;

    // Use this for initialization
    void Start () {
        ballBody = gameObject.GetComponent<Rigidbody>();
        ballBody.isKinematic = true;
        scoreTxt = GameObject.Find("Score").GetComponent<Text>();
        score = 0;
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
            ballBody.AddExplosionForce(250f, transform.position, 10f);
            SetScore(1);
        }else if (coll.gameObject.tag == "PinDeath")
        {

        }
    }

    public void SetScore(int points)
    {
        score += points;
        scoreTxt.text = "$ " + score.ToString();
    }

    public void LostHp(int damage)
    {

    }
}
