using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chickenrice : MonoBehaviour
{
    public GameObject falscherKnopf;
    public GameObject falscherText;
    public GameObject echterKnopf;
    public GameObject echterText;
    public int aktuellerReis;
    public static int chickenriceAnzahl = 0;
    public static int chickenriceValue = 750;
    public static bool KnopfAusschalten = false;
    public GameObject chickenriceStats;   
    public static int chickenriceProSekunde = 0;
    

void Update()
    {
        aktuellerReis = ReisAnzahl.Reiskörner;
        chickenriceStats.GetComponent<TextMeshProUGUI>().text = "Chickenrice: " + chickenriceAnzahl + " @ " + chickenriceProSekunde + " Pro Sekunde";
        falscherText.GetComponent<TextMeshProUGUI>().text = "Kaufe Chickenrice - Reis " + chickenriceValue;
        echterText.GetComponent<TextMeshProUGUI>().text = "Kaufe Chickenrice - Reis " + chickenriceValue;
        if (aktuellerReis >= chickenriceValue)
        {
            falscherKnopf.SetActive(false);
            echterKnopf.SetActive(true);
        }
        if (KnopfAusschalten == true)
        {
            echterKnopf.SetActive(false);
            falscherKnopf.SetActive(true);
            KnopfAusschalten = false;
        }
    }
}
