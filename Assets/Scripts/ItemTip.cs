using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTip : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    public GameObject goldSword;
    public GameObject redSword;
    public GameObject silverSword;
    public GameObject axe;


    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;

    public Button btngoldSword;
    public Button btnredSword;
    public Button btnsilverSword;
    public Button btnaxe;


    bool itemActive1 = false;
    bool itemActive2 = false;
    bool itemActive3 = false;
    bool itemActive4 = false;

    bool goldSwordActive = false;
    bool redSwordActive = false;
    bool silverSwordActive = false;
    bool axeActive = false;


    void Start()
    {
        btn1 = GameObject.Find("Slot1").GetComponent<Button>();
        btn2 = GameObject.Find("Slot2").GetComponent<Button>();
        btn3 = GameObject.Find("Slot3").GetComponent<Button>();
        btn4 = GameObject.Find("Slot4").GetComponent<Button>();

        btngoldSword = GameObject.Find("goldswordbtn").GetComponent<Button>();
        btnredSword = GameObject.Find("redswordbtn").GetComponent<Button>();
        btnsilverSword = GameObject.Find("silverswordbtn").GetComponent<Button>();
        btnaxe = GameObject.Find("axebtn").GetComponent<Button>();

        item1.gameObject.SetActive(itemActive1);
        item2.gameObject.SetActive(itemActive2);
        item3.gameObject.SetActive(itemActive3);
        item4.gameObject.SetActive(itemActive4);

        goldSword.gameObject.SetActive(goldSwordActive);
        redSword.gameObject.SetActive(redSwordActive);
        silverSword.gameObject.SetActive(silverSwordActive);
        axe.gameObject.SetActive(axeActive);


        btn1.onClick.AddListener(btnClick1);
        btn2.onClick.AddListener(btnClick2);
        btn3.onClick.AddListener(btnClick3);
        btn4.onClick.AddListener(btnClick4);

        btngoldSword.onClick.AddListener(btnGoldSword);
        btnredSword.onClick.AddListener(btnRedSword);
        btnsilverSword.onClick.AddListener(btnSilverSword);
        btnaxe.onClick.AddListener(btnAxe);


    }

    void Update()
    {
    }

    void btnClick1()
    {
        if (item2.activeSelf == false && item3.activeSelf == false && item4.activeSelf == false)
        {
            {
                itemActive1 = !itemActive1;
                item1.SetActive(itemActive1);
            }
        }
    }

    void btnClick2()
    {
        if (item1.activeSelf == false && item3.activeSelf == false && item4.activeSelf == false)
        {
            itemActive2 = !itemActive2;
            item2.SetActive(itemActive2);
        }
    }

    void btnClick3()
    {
        if (item1.activeSelf == false && item2.activeSelf == false && item4.activeSelf == false)
        {
            itemActive3 = !itemActive3;
            item3.SetActive(itemActive3);
        }
    }

    void btnClick4()
    {
        if (item1.activeSelf == false && item2.activeSelf == false && item3.activeSelf == false)
        {
            itemActive4 = !itemActive4;
            item4.SetActive(itemActive4);
        }
    }

    void btnGoldSword()
    {
        if (redSword.activeSelf == false && silverSword.activeSelf == false && axe.activeSelf == false)
        {
            if (goldSword.activeSelf == false && GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount > 1)
            {
                goldSwordActive = true;
                goldSword.SetActive(goldSwordActive);
                GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount = GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount - 2;
            }

            else if (goldSword.activeSelf == true)
            {
                goldSwordActive = false;
                goldSword.SetActive(goldSwordActive);
            }
        }
    }

    void btnRedSword()
    {
        if (goldSword.activeSelf == false && silverSword.activeSelf == false && axe.activeSelf == false)
        {
            if (redSword.activeSelf == false && GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount > 1)
            {
                redSwordActive = true;
                redSword.SetActive(redSwordActive);
                GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount = GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount - 2;
            }

            else if (redSword.activeSelf == true)
            {
                redSwordActive = false;
                redSword.SetActive(redSwordActive);
            }
        }
    }

    void btnSilverSword()
    {
        if (goldSword.activeSelf == false && redSword.activeSelf == false && axe.activeSelf == false)
        {
            if (silverSword.activeSelf == false && GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount > 1)
            {
                silverSwordActive = true;
                silverSword.SetActive(silverSwordActive);
                GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount = GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount - 2;
            }

            else if (silverSword.activeSelf == true)
            {
                silverSwordActive = false;
                silverSword.SetActive(silverSwordActive);
            }
        }
    }

    void btnAxe()
    {
        if (goldSword.activeSelf == false && silverSword.activeSelf == false && redSword.activeSelf == false)
        {
            if (axe.activeSelf == false && GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount > 1)
            {
                axeActive = true;
                axe.SetActive(axeActive);
                GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount = GameObject.Find("BigTree").GetComponent<FireStart>().rubyCount - 2;
            }

            else if (axe.activeSelf == true)
            {
                axeActive = false;
                axe.SetActive(axeActive);
            }
        }
    }

}
