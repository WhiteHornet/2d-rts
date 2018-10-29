using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    //public float speed;
    //public Transform movespot;
    //private float waitTime;
    //public float startWaitTime;
    //public float minX;
    //public float maxX;
    //public float minY;
    //public float maxY;
    public int ranNum;
    public GameObject blinky;
    public float speed = 0.3f;
    public float minY = -2f;
    public float maxY = 2f;
    public float minX = -11f;
    public float maxX = 11f;



    // Use this for initialization
    void Start()
    {
        ranNum = 0;

        //rb = GetComponent<Rigidbody2D>();
        //waitTime = startWaitTime;
        //movespot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        // Update is called once per frame

    }

    void FixedUpdate()
    {
        ranNum = Random.Range(1, 5);
        switch (ranNum)
        {
            case 1:
                blinky.transform.Translate(Vector2.up * speed);
                break;
            case 2:
                blinky.transform.Translate(-Vector2.up * -speed);
                break;
            case 3:
                blinky.transform.Translate(Vector2.right * speed);
                break;
            case 4:
                blinky.transform.Translate(-Vector2.right * -speed);
                break;

        }

    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    Debug.Log("Collided!");
    //    if (col.gameObject.name == "maze")
    //        ranNum = Random.Range(1, 5);
    //}

    //transform.position = Vector2.MoveTowards(transform.position, movespot.position, speed * Time.deltaTime);
    //if (Vector2.Distance(transform.position, movespot.position) < 0.2f)
    //{
    //    if (waitTime <= 0)
    //    {
    //        movespot.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    //        waitTime = startWaitTime;
    //    }
    //    else
    //    {
    //        waitTime -= Time.deltaTime;
    //    }
    //}

}



