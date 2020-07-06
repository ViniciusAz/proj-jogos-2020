using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Animator anim;

    public float velocidade;

    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetBool("Parado", false);
        if (Input.GetKey("w") || Input.GetKey("up")) {
            anim.SetBool("Costas", true);
            transform.position = new UnityEngine.Vector3(transform.position.x, transform.position.y + velocidade);
            transform.Translate(0, velocidade, 0);
        } else if (Input.GetKey("a") || Input.GetKey("left")) {
            anim.SetBool("Esquerda", true);
            transform.position = new UnityEngine.Vector3(transform.position.x - velocidade, transform.position.y);
            transform.Translate(-velocidade, 0, 0);
        } else if (Input.GetKey("s") || Input.GetKey("down")) {
            anim.SetBool("Frente", true);
            transform.position = new UnityEngine.Vector3(transform.position.x, transform.position.y - velocidade);
            transform.Translate(0, -velocidade, 0);
        } else if (Input.GetKey("d") || Input.GetKey("right")) {
            anim.SetBool("Direita", true);
            transform.position = new UnityEngine.Vector3(transform.position.x + velocidade, transform.position.y);
            transform.Translate(velocidade, 0, 0);
        } else {
            anim.SetBool("Parado", true);
            anim.SetBool("Costas", false);
            anim.SetBool("Frente", false);
            anim.SetBool("Esquerda", false);
            anim.SetBool("Direita", false);
        }
    }
}
