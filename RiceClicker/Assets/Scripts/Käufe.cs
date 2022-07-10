using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Käufe : MonoBehaviour
{
    public GameObject statusBox;
    public GameObject AutoReis;
    public static int ReiskocherReisProUpgrade = 50;
    public static int SushiReisProUpgrade = 250;
    public static int ChickenriceReisProUpgrade = 1000;
    public static int ReisProKlickReisProUpgrade = 2;

    public void StartAutoReisReiskocher()
    {
        if (ReisAnzahl.Reiskörner >= Reiskocher.ReiskocherValue)
        {
            AutoReis.SetActive(true);
            ReisAnzahl.Reiskörner -= Reiskocher.ReiskocherValue;
            Reiskocher.ReiskocherValue *= 2;
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            Reiskocher.ReiskocherProSekunde += ReiskocherReisProUpgrade;
            Reiskocher.ReiskocherAnzahl += 1;
        }
    }
    public void StartAutoReisSushi()
    {
        if (ReisAnzahl.Reiskörner >= Sushi.SushiValue)
        {
            AutoReis.SetActive(true);
            ReisAnzahl.Reiskörner -= Sushi.SushiValue;
            Sushi.SushiValue *= 2;
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            Sushi.SushiProSekunde += SushiReisProUpgrade;
            Sushi.SushiAnzahl += 1;
        }
    }

    public void StartAutoReisChickenrice()
    {
        if (ReisAnzahl.Reiskörner >= Chickenrice.chickenriceValue)
        {
            AutoReis.SetActive(true);
            ReisAnzahl.Reiskörner -= Chickenrice.chickenriceValue;
            Chickenrice.chickenriceValue *= 2;                   
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            Chickenrice.chickenriceProSekunde += ChickenriceReisProUpgrade;
            Chickenrice.chickenriceAnzahl += 1;
        }
    }

    public void ReisProKlickVerbessern()
    {
        if (ReisAnzahl.Reiskörner >= ReisProKlick.ReisProKlickValue)
        {
            ReisAnzahl.Reiskörner -= ReisProKlick.ReisProKlickValue;
            ReisProKlick.ReisProKlickValue *= 2;
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            ReisProKlick.KnopfAusschalten = true;
            Klickfunktion.ReisProKlick += ReisProKlickReisProUpgrade;
            ReisProKlick.ReisProKlickStufe++;
        }
    }

    public void NichtGenugReisAnimation()
    {    
            statusBox.GetComponent<TextMeshProUGUI>().text = "Nicht genügend Reis";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }
}
