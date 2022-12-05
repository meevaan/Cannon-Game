using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float timeStart = 60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;

        if (timeStart <= 0)
        {
            this.transform.position = new Vector3(-7.37f, 0f, 0f);
        }
    }
}
