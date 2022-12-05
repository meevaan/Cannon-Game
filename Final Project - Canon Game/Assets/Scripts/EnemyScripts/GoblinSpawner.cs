using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinSpawner : MonoBehaviour
{
    public GameObject Goblin;
    public GameObject bigGoblin;
    public GameObject smallGoblin;

    public float currentTime = 60;
    public float currentTime2 = 60;

    public int howMany;

    public float lastFired;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmpGoblin;

        for (int i = 0; i < howMany; i++)

            tmpGoblin = Instantiate(
            Goblin,
            new Vector3(Random.Range(10, 14), Random.Range(-4, 4), 1),
            Quaternion.identity
         );
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tmpsmallGoblin;
        GameObject tmpbigGoblin;

        currentTime -= Time.deltaTime;
        currentTime2 -= Time.deltaTime;

        if (currentTime <= 50)
        {
            tmpsmallGoblin = Instantiate(
                smallGoblin,
                new Vector3(Random.Range(10, 14), Random.Range(-4, 4), 1),
                Quaternion.identity
                );
            currentTime += 10;
        }

        if (currentTime2 <= 30)
        {
            tmpbigGoblin = Instantiate(
                bigGoblin,
                new Vector3(Random.Range(10, 14), Random.Range(-4, 4), 1),
                Quaternion.identity
                );
            currentTime2 += 15;
        }
    }
}