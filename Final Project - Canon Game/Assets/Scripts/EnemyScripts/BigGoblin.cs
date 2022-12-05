using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigGoblin : MonoBehaviour
{
    public float health = 4f;

    public GameObject myPart;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject part;

        if (health == 0f)
        {
            Destroy(this.gameObject);
            part = Instantiate(myPart,
                this.transform.position,
                this.transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);

            health -= 1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BigBall")
        {
            health -= 3f;
        }
    }
}
