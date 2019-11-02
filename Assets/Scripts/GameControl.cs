using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public GameObject menu;

    public GameObject satisfaction;

    float larguraTotal; //Guarda o valor da largura máxima da barra



    void Awake() //É chamada antes de Start
    {
        menu.SetActive(false);

        Time.timeScale = 1f;

        larguraTotal = satisfaction.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("p")) {
            if (menu.activeSelf)
            {
                Despausar();
            }
            else {
                Pausar();
            }
        }

        if (Input.GetKeyDown("c")) {
            DiminuirBarra();
        }

        if (Input.GetKeyDown("v")) {
            AumentarBarra();
        }

    }

    public void Pausar() {

        Time.timeScale = 0f;
        menu.SetActive(true);
    }

    public void Despausar() {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void DiminuirBarra(){
        float scale = satisfaction.transform.localScale.x - 0.15f;

        if (scale < 0f)
        {

            satisfaction.transform.localScale = new Vector2(0f, satisfaction.transform.localScale.y);
        }
        else {
            satisfaction.transform.localScale = new Vector2(scale, satisfaction.transform.localScale.y);
        }
    }

    public void AumentarBarra() {
        float scale = satisfaction.transform.localScale.x + 0.1f;

        if (scale > larguraTotal)
        {
            satisfaction.transform.localScale = new Vector2(larguraTotal, satisfaction.transform.localScale.y);
        }
        else {
            satisfaction.transform.localScale = new Vector2(scale, satisfaction.transform.localScale.y);
        }
    }

    public void Acelerar() {
        Time.timeScale++;
    }

    public void Desacelerar() {
        Time.timeScale = 1f;
    }



}
