using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicKenControll : MonoBehaviour
{

    private Animator anim;
    private Rigidbody rigid;
    public float eatDelay;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        StartCoroutine(chicKenAnim());
    }

    IEnumerator chicKenAnim()
    {
        anim.SetBool("Eat", true);
        yield return new WaitForSeconds(eatDelay);

        anim.SetBool("Eat", false);
        //yield return new WaitForSeconds(eatDelay);
    }
}
