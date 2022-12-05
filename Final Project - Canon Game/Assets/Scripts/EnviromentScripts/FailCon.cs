using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class FailCon : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private CanvasGroup myUIGroup2;

    public float waitTime = 5;

    public string loadScene;

    // Start is called before the first frame update
    void Start()
    {

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goblin")
        {
            myUIGroup.alpha = 0.4f;
            myUIGroup2.alpha = 1f;
        }

        if (collision.gameObject.tag == "SmallGoblin")
        {
            myUIGroup.alpha = 0.4f;
            myUIGroup2.alpha = 1f;
        }

        if (collision.gameObject.tag == "BigGoblin")
        {
            myUIGroup.alpha = 0.4f;
            myUIGroup2.alpha = 1f;
        }
    }
}
