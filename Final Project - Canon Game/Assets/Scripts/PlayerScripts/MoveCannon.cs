using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCannon : MonoBehaviour
{
    public string up;
    public string down;
    public string turnLeft;
    public string turnRight;

    public string fire;
    public GameObject cannonBall;
    public string special;
    public GameObject bigCannonBall;

    public float lastFired;
    public float bigLastFired;

    public GameObject cannonPart;
    public GameObject myPart;

    public GameObject fireAudio;

    float xPos;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            this.transform.Translate(new Vector3(-5f, 0, 0) * Time.deltaTime * 1);
        }

        if (Input.GetKey(down))
        {
            this.transform.Translate(new Vector3(5f, 0, 0) * Time.deltaTime * 1);
        }

        if (Input.GetKey(turnLeft))
        {
            this.transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime);
        }

        if (Input.GetKey(turnRight))
        {
            this.transform.Rotate(new Vector3(0f, 0f, -100f) * Time.deltaTime);
        }


        GameObject tmpBullet;
        GameObject part;

        if(Input.GetMouseButtonDown(0))
        {
            if (Time.time>lastFired+1)
            {
                tmpBullet = Instantiate(cannonBall, this.transform.position + 
                    this.transform.up, this.transform.rotation);
                lastFired = Time.time;

                part = Instantiate(cannonPart,
                this.transform.position,
                this.transform.rotation);

                fireAudio.GetComponent<AudioSource>().Play();
            }
        }

        GameObject tmpbigCannonBall;

        if(Input.GetMouseButtonDown(1))
        {
            if(Time.time>bigLastFired+15)
            {
                tmpbigCannonBall = Instantiate(bigCannonBall, this.transform.position +
                    this.transform.up, this.transform.rotation);
                bigLastFired = Time.time;

                part = Instantiate(cannonPart,
                this.transform.position,
                this.transform.rotation);

                fireAudio.GetComponent<AudioSource>().Play();
            }
        }
    }

    void awake()
    {
        xPos = transform.position.x;
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(xPos -8.17f, transform.position.y, 0);
    }
}

