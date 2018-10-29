using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour {

    public float itemUp = 0.1f;
    public float itemMove = 0.7f;
    public float x;
    float y;
    float z;
    Vector3 pos;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.right * itemMove * Time.deltaTime;

        x = 0;
        y = Random.Range(-50, 100);
        z = 2;
        pos = new Vector3(-x, y, z);
        transform.position = pos * itemUp * Time.deltaTime;

    }


}
