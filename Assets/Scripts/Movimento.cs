using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetBool("Frente", false);
        anim.SetBool("Costas", false);
        anim.SetBool("Parado", true);



        if (Input.GetKey("s")) {
            anim.SetBool("Parado", false);
            anim.SetBool("Frente", true);

        }
        if (Input.GetKey("w"))
        {
            anim.SetBool("Parado", false);
            anim.SetBool("Costas", true);
        }


    }
}
