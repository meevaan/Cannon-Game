using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Spear : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;

    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private CanvasGroup myUIGroup2;

    public float waitTime = 5;

    public string loadScene;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (myUIGroup2.alpha >= 1f)
        {
            waitTime -= Time.deltaTime;

            if (waitTime <= 0)
            {
                SceneManager.LoadScene(loadScene);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        Destroy(collision.gameObject);

        myUIGroup.alpha = 0.4f;
        myUIGroup2.alpha = 1f;
    }
}
