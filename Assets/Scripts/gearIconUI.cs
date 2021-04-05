using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gearIconUI : MonoBehaviour
{
    public GameObject gearIconPanel;
    bool activegearIconPanel = false;
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        gearIconPanel.SetActive(activegearIconPanel);

        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(btnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void btnClick()
    {
        activegearIconPanel = !activegearIconPanel;
        gearIconPanel.SetActive(activegearIconPanel);
    }
}
