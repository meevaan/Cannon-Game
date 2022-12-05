using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBigCannonBall : MonoBehaviour
{
    private Rigidbody2D myRigid;
    public GameObject myPart;

    public GameObject Goblin;
    public GameObject smallGoblin;

    public float upTime = 3;

    public Vector3 sizeChange;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigid.AddForce(this.transform.up*2);

        if (transform.position.x > 10.5)
        {
            Destroy(this.gameObject);
        }

        upTime -= Time.deltaTime;

        if (upTime < 3)
        {
            this.transform.localScale += sizeChange;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject tmpGoblin;
        GameObject part;

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
    }
}
