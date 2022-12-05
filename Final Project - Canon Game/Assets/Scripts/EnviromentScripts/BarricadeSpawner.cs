using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeSpawner : MonoBehaviour
{
    public GameObject Barricade;
    public int howMany;

    // Start is called before the first frame update
    void Start()
    {
        GameObject tmpBarricade;
        for (int i = 0; i < howMany; i++)

            tmpBarricade = Instantiate(
            Barricade,
            new Vector3(Random.Range(-5, -3), Random.Range(-4, 4), 1),
            Quaternion.identity
         );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
