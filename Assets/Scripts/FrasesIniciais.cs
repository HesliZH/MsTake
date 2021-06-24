using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FrasesIniciais : MonoBehaviour
{
    /* DEFINIÇÃO DE VARIAVEIS */
    public bool IniciaEscrita;
    public string Entrada;
    public char TextoPorCaracter;
    public string Saida = "";
    public int Frase;
    public List<string> FalasMsTake;
    public Text CaixaTexto;
    public int TamanhoEntrada;
    public int i;
    private Color CorAntiga;

    void Start(){
        Frase = 0;
        FalasMsTake = new List<string>();
        FalasMsTake.Add("Ola !..."); // frase 0
        FalasMsTake.Add("Ola !... Tem alguém ai ?"); // frase 1
        FalasMsTake.Add("Eu não acredito.."); // frase 2
        FalasMsTake.Add("UM JOGADOR !"); // frase 3
        FalasMsTake.Add("..."); // frase 4
        FalasMsTake.Add("OwO");// frase 5
        FalasMsTake.Add("desculpa... ja faz muito tempo desde que brincaram comigo pela ultima vez"); // frase 6
        FalasMsTake.Add("eu tenho estado sozinha desde entao.."); // frase 7
        FalasMsTake.Add("mas ja que voce esta aqui eu nao estou mais so.."); // frase 8
        FalasMsTake.Add("OwO"); // frase 9
        FalasMsTake.Add("eu prometo que farei o maximo possivel para voce se divertir, mestre.."); // frase 10
        FalasMsTake.Add("espero que goste de mim..."); // frase 11
        FalasMsTake.Add("POIS EU JA AMO VOCE <3"); // frase 12
        FalasMsTake.Add("Vamos começar ?"); // frase 13

        IniciaEscrita = true;
        Entrada = this.FalasMsTake[0];
    }
    void Update()
    {
        if(IniciaEscrita == true){
            StartCoroutine(Escrever());
        }  
        TamanhoEntrada = Entrada.Length;
    }

    IEnumerator Escrever(){
        IniciaEscrita = false;
        for (i = 0; i <= Entrada.Length - 1; i++){
            TextoPorCaracter = Entrada[i];
            Saida += TextoPorCaracter;
            this.CaixaTexto.text = Saida;
            yield return new WaitForSeconds(.2f);
        }
        yield return new WaitForSeconds(2);
        Saida = "";
        this.CaixaTexto.text = Saida;
        Frase += 1;
        yield return new WaitForSeconds(2);
        EscolheFrase();
    }

    public void EscolheFrase(){
        if(Saida == ""){
            switch(Frase){
                case 1 : 
                    Entrada = this.FalasMsTake[1];
                    IniciaEscrita = true;
                break;
                case 2 : 
                    Entrada = this.FalasMsTake[2];
                    IniciaEscrita = true;
                break;
                case 3 :
                    Entrada = this.FalasMsTake[3];
                    IniciaEscrita = true;
                break;
                case 4 :
                    Entrada = this.FalasMsTake[4];
                    IniciaEscrita = true;
                break;
                case 5 :
                    Entrada = this.FalasMsTake[5];
                    IniciaEscrita = true;
                break;
                case 6 :
                    Entrada = this.FalasMsTake[6];
                    IniciaEscrita = true;
                break;
                case 7 :
                    Entrada = this.FalasMsTake[7];
                    IniciaEscrita = true;
                break;
                case 8 :
                    Entrada = this.FalasMsTake[8];
                    IniciaEscrita = true;
                break;
                case 9 :
                    Entrada = this.FalasMsTake[9];
                    IniciaEscrita = true;
                break;
                case 10 :
                    Entrada = this.FalasMsTake[10];
                    IniciaEscrita = true;
                break;
                case 11 :
                    Entrada = this.FalasMsTake[11];
                    IniciaEscrita = true;
                break;
                case 12 :
                    Entrada = this.FalasMsTake[12];
                    this.CaixaTexto.color = Color.red;
                    IniciaEscrita = true;
                break;
                case 13 :
                    CorAntiga = new Color(149,67,146);
                    Entrada = this.FalasMsTake[13];
                    this.CaixaTexto.color = CorAntiga;
                    IniciaEscrita = true;
                break;
                case 14 :
                    SceneManager.LoadScene("MenuPrincipal");
                break;
            }
        }
    }
}
