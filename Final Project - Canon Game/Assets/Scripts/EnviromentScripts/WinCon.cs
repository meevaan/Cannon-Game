using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;
    [SerializeField] private CanvasGroup myUIGroup2;

    public float timeStart = 60;

    public float waitTime = 5;

    public string loadScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;

        if (timeStart<=0)
        {
            myUIGroup.alpha = 0.4f;
            myUIGroup2.alpha = 1f;

            if (myUIGroup2.alpha >= 1f)
            {
                waitTime -= Time.deltaTime;

                if (waitTime <= 0)
                {
                    SceneManager.LoadScene(loadScene);
                }
            }
        }
    }
}
