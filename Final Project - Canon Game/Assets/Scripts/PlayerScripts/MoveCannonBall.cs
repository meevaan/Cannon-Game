using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCannonBall : MonoBehaviour
{
    private Rigidbody2D myRigid;
    public GameObject myPart;

    public GameObject Goblin;
    public GameObject smallGoblin;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        myRigid.AddForce(this.transform.up * 5);

        if (transform.position.x > 10.5)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score.instance.AddPoint(); 

        GameObject part;
        GameObject tmpGoblin;

        if (collision.gameObject.tag == "Goblin")
        {
            part = Instantiate(myPart,
                this.transform.position,
                this.transform.rotation);
            Destroy(collision.gameObject);

            tmpGoblin = Instantiate(
            Goblin,
            new Vector3(Random.Range(10, 14), Random.Range(-3, 3), 1),
            Quaternion.identity
            );
        }
        Destroy(this.gameObject);

        if (collision.gameObject.tag == "SmallGoblin")
        { 
            part = Instantiate(myPart,
                this.transform.position,
                this.transform.rotation);
            Destroy(collision.gameObject);

            tmpGoblin = Instantiate(
            Goblin,
            new Vector3(Random.Range(10, 14), Random.Range(-3, 3), 1),
            Quaternion.identity
            );
        }
        Destroy(this.gameObject);


    }
}
