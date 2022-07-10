using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReisProKlick : MonoBehaviour
{
    public int aktuellerReis;
    public GameObject falscherKnopf;
    public GameObject falscherText;
    public GameObject echterKnopf;
    public GameObject echterText;
    public static bool KnopfAusschalten = false;
    public static int ReisProKlickStufe = 1;
    public static int ReisProKlickValue = 5;
    public GameObject ReisProKlickStats;

    void Update()
    {
        aktuellerReis = ReisAnzahl.Reiskörner;
        ReisProKlickStats.GetComponent<TextMeshProUGUI>().text = "Reis Pro Klick: " + Klickfunktion.ReisProKlick + " auf Stufe " + ReisProKlickStufe;
        falscherText.GetComponent<TextMeshProUGUI>().text = "Reis Pro Klick verbessern - Reis " + ReisProKlickValue;
        echterText.GetComponent<TextMeshProUGUI>().text = "Reis Pro Klick verbessern - Reis " + ReisProKlickValue;
        if (aktuellerReis >= ReisProKlickValue)
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
