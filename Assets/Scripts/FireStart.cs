using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FireStart : MonoBehaviour
{

    public GameObject longFire;
    public GameObject smallTree;

    public int woodCount = 0;

    public bool woodCountActive;

    public Text WoodCountText;

    public Text RubyCountText;
    public int rubyCount;
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Ruby", rubyCount);
        PlayerPrefs.SetInt("Wood", woodCount);
    }

    void Start()
    {
        woodCountActive = true;
        rubyCount = PlayerPrefs.GetInt("Ruby", 2);
        woodCount = PlayerPrefs.GetInt("Wood", 0);

    }

    void Update()
    {
        RubyCountText.text = " x " + rubyCount;

        WoodCountText.text = "Wood x " + woodCount;
        if (woodCount >= 1 && woodCountActive == true)
        {
            woodCountActive = false;
            startFire();
            StartCoroutine(woodCountDelay());
        }

        if (woodCount <= 0 && woodCountActive == true)
        {
            woodEndFire();
        }

        HpManager();
    }

    IEnumerator woodCountDelay()
    {
        if (woodCountActive == false)
        {
            yield return new WaitForSeconds(10);
            woodCountDown();
            woodCountActive = true;
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && woodCount <= 49)
        {
            woodCountUp();
        }
    }

    void startFire()
    {
        smallTree.SetActive(true);
        longFire.SetActive(true);
    }

    void woodEndFire()
    {
        smallTree.SetActive(false);
        longFire.SetActive(false);
    }

    void woodCountUp()
    {
        woodCount = woodCount + 1;
    }

    void woodCountDown()
    {
        woodCount = woodCount - 1;
    }

    void HpManager()
    {
        if (smallTree.activeSelf == true)
        {
            if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp < 100)
            {
                GameObject.Find("Temperature1").GetComponent<HpSlider>().hp += 0.2f;
            }

            if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp > 99 && GameObject.Find("Temperature2").GetComponent<HpSlider>().hp < 100)
            {
                GameObject.Find("Temperature2").GetComponent<HpSlider>().hp += 0.2f;
            }

            if (GameObject.Find("Temperature2").GetComponent<HpSlider>().hp > 99 && GameObject.Find("Temperature3").GetComponent<HpSlider>().hp < 100)
            {
                GameObject.Find("Temperature3").GetComponent<HpSlider>().hp += 0.2f;
            }

            if (GameObject.Find("Temperature3").GetComponent<HpSlider>().hp > 99 && GameObject.Find("Temperature4").GetComponent<HpSlider>().hp < 100)
            {
                GameObject.Find("Temperature4").GetComponent<HpSlider>().hp += 0.2f;
            }

            if (GameObject.Find("Temperature4").GetComponent<HpSlider>().hp > 99 && GameObject.Find("Temperature5").GetComponent<HpSlider>().hp < 100)
            {
                GameObject.Find("Temperature5").GetComponent<HpSlider>().hp += 0.2f;
            }
        }


        if (smallTree.activeSelf == !true)
        {
            if (GameObject.Find("Temperature2").GetComponent<HpSlider>().hp < 1 && GameObject.Find("Temperature1").GetComponent<HpSlider>().hp > 0)
            {
                GameObject.Find("Temperature1").GetComponent<HpSlider>().hp -= 0.2f;
            }

            if (GameObject.Find("Temperature3").GetComponent<HpSlider>().hp < 1 && GameObject.Find("Temperature2").GetComponent<HpSlider>().hp > 0)
            {
                GameObject.Find("Temperature2").GetComponent<HpSlider>().hp -= 0.2f;
            }

            if (GameObject.Find("Temperature4").GetComponent<HpSlider>().hp < 1 && GameObject.Find("Temperature3").GetComponent<HpSlider>().hp > 0)
            {
                GameObject.Find("Temperature3").GetComponent<HpSlider>().hp -= 0.2f;
            }

            if (GameObject.Find("Temperature5").GetComponent<HpSlider>().hp < 1 && GameObject.Find("Temperature4").GetComponent<HpSlider>().hp > 0)
            {
                GameObject.Find("Temperature4").GetComponent<HpSlider>().hp -= 0.2f;
            }

            if (GameObject.Find("Temperature5").GetComponent<HpSlider>().hp > 0)
            {
                GameObject.Find("Temperature5").GetComponent<HpSlider>().hp -= 0.2f;
            }
        }
    }
}