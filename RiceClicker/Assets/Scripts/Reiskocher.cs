using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Reiskocher : MonoBehaviour
{
    public GameObject falscherKnopf;
    public GameObject falscherText;
    public GameObject echterKnopf;
    public GameObject echterText;
    public int aktuellerReis;
    public static int ReiskocherValue = 69;
    public static bool KnopfAusschalten = false;
    public GameObject ReiskocherStats;
    public static int ReiskocherAnzahl;
    public static int ReiskocherProSekunde;
    void Start()
    {
        
    }


    void Update()
    {
        aktuellerReis = ReisAnzahl.Reiskörner;
        ReiskocherStats.GetComponent<TextMeshProUGUI>().text= "Reiskocher: " + ReiskocherAnzahl + " @ " + ReiskocherProSekunde + " Pro Sekunde";
        falscherText.GetComponent<TextMeshProUGUI>().text = "Kaufe Reiskocher - Reis " + ReiskocherValue;
        echterText.GetComponent<TextMeshProUGUI>().text = "Kaufe Reiskocher - Reis " + ReiskocherValue;
        if (aktuellerReis >= ReiskocherValue)
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
