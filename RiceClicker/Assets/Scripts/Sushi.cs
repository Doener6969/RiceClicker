using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sushi : MonoBehaviour
{
    public GameObject falscherKnopf;
    public GameObject falscherText;
    public GameObject echterKnopf;
    public GameObject echterText;
    public long aktuellerReis;
    public static int SushiAnzahl = 0;
    public static int SushiValue = 200;
    public static bool KnopfAusschalten = false;
    public GameObject SushiStats;
    public static int SushiProSekunde = 0;


void Update()
    {
        aktuellerReis = ReisAnzahl.Reiskörner;
        SushiStats.GetComponent<TextMeshProUGUI>().text = "Sushi: " + SushiAnzahl + " @ " + SushiProSekunde + " Pro Sekunde";
        falscherText.GetComponent<TextMeshProUGUI>().text = "Kaufe Sushi - Reis " + SushiValue;
        echterText.GetComponent<TextMeshProUGUI>().text = "Kaufe Sushi - Reis " + SushiValue;
        if (aktuellerReis >= SushiValue)
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
