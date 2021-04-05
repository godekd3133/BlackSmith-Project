using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool activeinventory = false;
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        inventoryPanel.SetActive(activeinventory);

        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(btnClick);
    }

    // Update is called once per frame
    void Update()
    {
        ItemOpen();
    }

    void ItemOpen()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeinventory = !activeinventory;
            inventoryPanel.SetActive(activeinventory);
        }
    }

    void btnClick()
    {
        activeinventory = !activeinventory;
        inventoryPanel.SetActive(activeinventory);
    }
}
