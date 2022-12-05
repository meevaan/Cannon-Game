using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearSpawner : MonoBehaviour
{
    public float currentTime = 60;

    public GameObject spear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tmpspear;

        currentTime -= Time.deltaTime;

        if (currentTime <= 55)
        {
            tmpspear = Instantiate(
                spear,
                new Vector3(Random.Range(10, 14), Random.Range(-4, 4), 1),
                Quaternion.identity
                );
            currentTime += 10;
        }
    }
}
