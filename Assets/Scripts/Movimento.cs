using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Animator anim;

    public float velocidade;

    Rigidbody2D m_Rigidbody;

    int chave1;

    // Start is called before the first frame update
    void Start() {
        anim = GetComponent<Animator>();

        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;


        chave1 = 0;

        //GameObject.Find("porta-quarto-a").SetActive(false);
        GameObject.Find("porta-quarto-a").GetComponent<Renderer>().enabled = false;
        GameObject.Find("porta-baixo-a").GetComponent<Renderer>().enabled = false;
        GameObject.Find("porta-sala1-a (2)").GetComponent<Renderer>().enabled = false;
        GameObject.Find("porta-sala1-a").GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        anim.SetBool("Parado", false);
        if (Input.GetKey("w") || Input.GetKey("up")) {
            anim.SetBool("Costas", true);
            anim.SetBool("Direita", false);
            anim.SetBool("Frente", false);
            anim.SetBool("Esquerda", false);
            anim.SetBool("Parado", false);
            transform.position = new UnityEngine.Vector3(transform.position.x, transform.position.y + velocidade);
            transform.Translate(0, velocidade, 0);
        } else if (Input.GetKey("a") || Input.GetKey("left")) {
            anim.SetBool("Esquerda", true);
            anim.SetBool("Costas", false);
            anim.SetBool("Frente", false);
            anim.SetBool("Direita", false);
            anim.SetBool("Parado", false);
            transform.position = new UnityEngine.Vector3(transform.position.x - velocidade, transform.position.y);
            transform.Translate(-velocidade, 0, 0);
        } else if (Input.GetKey("s") || Input.GetKey("down")) {
            anim.SetBool("Frente", true);
            anim.SetBool("Costas", false);
            anim.SetBool("Direita", false);
            anim.SetBool("Esquerda", false);
            anim.SetBool("Parado", false);
            transform.position = new UnityEngine.Vector3(transform.position.x, transform.position.y - velocidade);
            transform.Translate(0, -velocidade, 0);
        } else if (Input.GetKey("d") || Input.GetKey("right")) {
            anim.SetBool("Direita", true);
            anim.SetBool("Costas", false);
            anim.SetBool("Frente", false);
            anim.SetBool("Esquerda", false);
            anim.SetBool("Parado", false);
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "armario-quarto") {
            GameObject.Find("porta-quarto-f").SetActive(false);
            //GameObject.Find("porta-quarto-a").SetActive(true);
            GameObject.Find("porta-quarto-a").GetComponent<Renderer>().enabled = true;
                
        }
        else if (collision.gameObject.name == "bota2")
        {
            GameObject.Find("porta-baixo-f").SetActive(false);
            //GameObject.Find("porta-quarto-a").SetActive(true);
            GameObject.Find("porta-baixo-a").GetComponent<Renderer>().enabled = true;

        }
        else if (collision.gameObject.name == "chave1")
        {
            GameObject.Find("chave1").SetActive(false);
            chave1 = 1;

        }
        else if ((collision.gameObject.name == "porta-sala1-f (2)") && chave1 == 1)
        {
            GameObject.Find("porta-sala1-f (2)").SetActive(false);
            //GameObject.Find("porta-quarto-a").SetActive(true);
            GameObject.Find("porta-sala1-a (2)").GetComponent<Renderer>().enabled = true;
        }
        else if ((collision.gameObject.name == "estante-livros-secret") && chave1 == 1) 
        {
            GameObject.Find("porta-sala1-f").SetActive(false);
            //GameObject.Find("porta-quarto-a").SetActive(true);
            GameObject.Find("porta-sala1-a").GetComponent<Renderer>().enabled = true;
        }
    }
}
