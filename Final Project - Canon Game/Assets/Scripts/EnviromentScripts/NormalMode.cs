using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalMode : MonoBehaviour
{
    public string whereToGo;
    public string changeScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(changeScene))
        {
            SceneManager.LoadScene(whereToGo);
        }
    }
}
