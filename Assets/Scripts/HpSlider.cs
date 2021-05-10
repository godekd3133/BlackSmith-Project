using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HpSlider : MonoBehaviour
{
    public Slider slHp;
    public float hp;
    public float hpFull;
    public int index;
    public GameObject hotSteam;


    public float damUpgoldfl = 0f;
    public float damUpredfl = 0f;
    public float damUpsilverfl = 0f;
    public float damUpaxefl = 0f;



    public Text damUpGoldSwordText;
    public Text damUpRedSwordText;
    public Text damUpSilverSwordText;
    public Text damUpAxeText;
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat($"{index}_hp", hp);
        PlayerPrefs.SetFloat($"{index}_hpFull", hpFull);
        PlayerPrefs.SetFloat($"{index}_damUpgoldfl", damUpgoldfl);
        PlayerPrefs.SetFloat($"{index}_damUpredfl", damUpredfl);
        PlayerPrefs.SetFloat($"{index}_damUpsilverfl", damUpsilverfl);
        PlayerPrefs.SetFloat($"{index}_damUpaxefl", damUpaxefl);
    }







    // Start is called before the first frame update
    void Start()
    {
        slHp = GetComponent<Slider>();
        hp = PlayerPrefs.GetFloat($"{index}_hp", 0);
        hpFull = PlayerPrefs.GetFloat($"{index}_hpFull", 100);
        damUpgoldfl = PlayerPrefs.GetFloat($"{index}_damUpgoldfl", 0);
        damUpredfl = PlayerPrefs.GetFloat($"{index}_damUpredfl", 0);
        damUpsilverfl = PlayerPrefs.GetFloat($"{index}_damUpsilverfl", 0);
        damUpaxefl = PlayerPrefs.GetFloat($"{index}_damUpaxefl", 0);


        InvokeRepeating("ItemDamageUp1", 0.2f, 0.2f);
        InvokeRepeating("ItemDamageUp2", 0.2f, 0.2f);
        InvokeRepeating("ItemDamageUp3", 0.2f, 0.2f);
        InvokeRepeating("ItemDamageUp4", 0.2f, 0.2f);



    }

    void Update()
    {

        slHp.value = hp / hpFull;
        SteamPlay();
    }

    void SteamPlay()
    {
        if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp > 50)
        {
            hotSteam.SetActive(true);
        }

        if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp < 50)
        {
            hotSteam.SetActive(false);
        }
    }

    void ItemDamageUp1()
    {

        if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("GoldSword").activeSelf == true)
                {
                    damUpgoldfl = damUpgoldfl + 0.0002f;
                    damUpGoldSwordText.text = "Damage" + damUpgoldfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g1");
            }
        }

        if (GameObject.Find("Temperature2").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("GoldSword").activeSelf == true)
                {
                    damUpgoldfl = damUpgoldfl + 0.0002f;
                    damUpGoldSwordText.text = "Damage" + damUpgoldfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g1");
            }
        }

        if (GameObject.Find("Temperature3").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("GoldSword").activeSelf == true)
                {
                    damUpgoldfl = damUpgoldfl + 0.0002f;
                    damUpGoldSwordText.text = "Damage" + damUpgoldfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g1");
            }
        }

        if (GameObject.Find("Temperature4").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("GoldSword").activeSelf == true)
                {
                    damUpgoldfl = damUpgoldfl + 0.0002f;
                    damUpGoldSwordText.text = "Damage" + damUpgoldfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g1");
            }
        }

        if (GameObject.Find("Temperature5").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("GoldSword").activeSelf == true)
                {
                    damUpgoldfl = damUpgoldfl + 0.0002f;
                    damUpGoldSwordText.text = "Damage" + damUpgoldfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g1");
            }
        }
    }

    void ItemDamageUp2()
    {

        if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("RedSword").activeSelf == true)
                {
                    damUpredfl = damUpredfl + 0.0002f;
                    damUpRedSwordText.text = "Damage" + damUpredfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature2").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("RedSword").activeSelf == true)
                {
                    damUpredfl = damUpredfl + 0.0002f;
                    damUpRedSwordText.text = "Damage" + damUpredfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature3").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("RedSword").activeSelf == true)
                {
                    damUpredfl = damUpredfl + 0.0002f;
                    damUpRedSwordText.text = "Damage" + damUpredfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature4").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("RedSword").activeSelf == true)
                {
                    damUpredfl = damUpredfl + 0.0002f;
                    damUpRedSwordText.text = "Damage" + damUpredfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature5").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("RedSword").activeSelf == true)
                {
                    damUpredfl = damUpredfl + 0.0002f;
                    damUpRedSwordText.text = "Damage" + damUpredfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }
    }

    void ItemDamageUp3()
    {

        if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("SilverSword").activeSelf == true)
                {
                    damUpsilverfl = damUpsilverfl + 0.0002f;
                    damUpSilverSwordText.text = "Damage" + damUpsilverfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature2").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("SilverSword").activeSelf == true)
                {
                    damUpsilverfl = damUpsilverfl + 0.0002f;
                    damUpSilverSwordText.text = "Damage" + damUpsilverfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature3").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("SilverSword").activeSelf == true)
                {
                    damUpsilverfl = damUpsilverfl + 0.0002f;
                    damUpSilverSwordText.text = "Damage" + damUpsilverfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature4").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("SilverSword").activeSelf == true)
                {
                    damUpsilverfl = damUpsilverfl + 0.0002f;
                    damUpSilverSwordText.text = "Damage" + damUpsilverfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature5").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("SilverSword").activeSelf == true)
                {
                    damUpsilverfl = damUpsilverfl + 0.0002f;
                    damUpSilverSwordText.text = "Damage" + damUpsilverfl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }
    }

    void ItemDamageUp4()
    {

        if (GameObject.Find("Temperature1").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("Axe").activeSelf == true)
                {
                    damUpaxefl = damUpaxefl + 0.0002f;
                    damUpAxeText.text = "Damage" + damUpaxefl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature2").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("Axe").activeSelf == true)
                {
                    damUpaxefl = damUpaxefl + 0.0002f;
                    damUpAxeText.text = "Damage" + damUpaxefl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature3").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("Axe").activeSelf == true)
                {
                    damUpaxefl = damUpaxefl + 0.0002f;
                    damUpAxeText.text = "Damage" + damUpaxefl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature4").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("Axe").activeSelf == true)
                {
                    damUpaxefl = damUpaxefl + 0.0002f;
                    damUpAxeText.text = "Damage" + damUpaxefl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }

        if (GameObject.Find("Temperature5").GetComponent<HpSlider>().hp >= 100)
        {
            try
            {
                if (GameObject.Find("Axe").activeSelf == true)
                {
                    damUpaxefl = damUpaxefl + 0.0002f;
                    damUpAxeText.text = "Damage" + damUpaxefl;
                }
            }
            catch (NullReferenceException)
            {
                Debug.Log("g2");
            }
        }
    }
}
