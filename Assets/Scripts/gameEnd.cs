using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameEnd : MonoBehaviour
{
    public Button gameEndbtn;

    // Start is called before the first frame update
    void Start()
    {
        gameEndbtn = this.GetComponent<Button>();
        gameEndbtn.onClick.AddListener(gameEndbtnClick);
    }

    // Update is called once per frame
    void Update()
    {
        backSpace();
    }

    void backSpace()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameEndbtnClick();
        }
    }

    void gameEndbtnClick()
    {
        Application.Quit();
    }
}
