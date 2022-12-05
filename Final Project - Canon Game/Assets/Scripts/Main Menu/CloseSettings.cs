using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSettings : MonoBehaviour
{
    [SerializeField] private CanvasGroup SettingsSlide;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void handleClick()
    {
        SettingsSlide.transform.position = new Vector3(2500, 250, 0);
    }
}
