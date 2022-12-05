using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSettings : MonoBehaviour
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
        SettingsSlide.transform.position = new Vector3(750, 250, 0);
    }
}