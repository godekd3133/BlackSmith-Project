using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameObject window;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (window.activeSelf == true)
                Application.Quit();
            else
                window.SetActive(true);
        }


    }
}
