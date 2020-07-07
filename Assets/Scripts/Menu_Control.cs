using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Menu_Control : MonoBehaviour
{
    GameObject[] lista_menu;
    int menu; // 0 = jogar; 1 = controles ; 2 = sair
    // Start is called before the first frame update
    void Start()
    {
        menu = 0;
        lista_menu = GameObject.FindGameObjectsWithTag("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            menu--;
            if (menu <= -1)
                menu = 2;
        }
        else if (Input.GetKeyDown("down"))
        {
            menu++;
            if (menu >= 3)
                menu = 0;
        }else if (Input.GetKeyDown (KeyCode.Space))
        {
            if (menu == 0)
            {
                SceneManager.LoadScene("SampleScene");
            }
            else if (menu == 1)
            {
                SceneManager.LoadScene("Controles");
            }
            else if (menu == 2)
            {
                Application.Quit();
            }

        }

        if (menu == 0)
        {
            for(int i = 0; i < lista_menu.Length; i++)
            {
                if (lista_menu[i].name.Equals("jogar_selecionado"))
                {
                    lista_menu[i].SetActive(true);
                }
                else
                {
                    lista_menu[i].SetActive(false);
                }
            }
        }
        else if (menu == 1)
        {
            for (int i = 0; i < lista_menu.Length; i++)
            {
                if (lista_menu[i].name.Equals("controles_selecionado"))
                {
                    lista_menu[i].SetActive(true);
                }
                else
                {
                    lista_menu[i].SetActive(false);
                }
            }
        }
        else if (menu == 2)
        {
            for (int i = 0; i < lista_menu.Length; i++)
            {
                if (lista_menu[i].name.Equals("sair_selecionado"))
                {
                    lista_menu[i].SetActive(true);
                }
                else
                {
                    lista_menu[i].SetActive(false);
                }
            }
        }

    }
}
