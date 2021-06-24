using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoMsTake : MonoBehaviour
{
    public Text LogoTake;
    public List<Color> CoresLogo;
    public bool AtivarTrocaCor;
    public bool AtivarPiscada;
    void Start()
    {
        AtivarPiscada = true;
        CoresLogo = new List<Color>();
        CoresLogo.Add(new Color(67,229,23));
        CoresLogo.Add(new Color(149,67,146));
    }

    void Update()
    {
        if(AtivarPiscada){
            StartCoroutine(Piscada());
        }
    }

    IEnumerator Piscada(){
        AtivarPiscada = false;
        LogoTake.enabled = false;
        TrocaCor();
        yield return new WaitForSeconds(.2f);
        LogoTake.enabled = true;
        yield return new WaitForSeconds(.2f);
        LogoTake.enabled = false;
        yield return new WaitForSeconds(.2f);
        LogoTake.enabled = true;
    }

    public void TrocaCor(){
        System.Random r = new System.Random();
        LogoTake.color = CoresLogo[r.Next(0,1)];
    }
}
