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
        if (ReisAnzahl.Reiskörner >= (long)Reiskocher.ReiskocherValue)
        {
            AutoReis.SetActive(true);
            ReisAnzahl.Reiskörner -= Reiskocher.ReiskocherValue;
            Reiskocher.ReiskocherAnzahl++;
            Reiskocher.ReiskocherValue = (int)(Mathf.Log(Reiskocher.ReiskocherAnzahl+1, 10)*1000 + 69);
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            Reiskocher.ReiskocherProSekunde += ReiskocherReisProUpgrade;
        
        }
    }
    public void StartAutoReisSushi()
    {
        if (ReisAnzahl.Reiskörner >= (long)Sushi.SushiValue)
        {
            AutoReis.SetActive(true);
            ReisAnzahl.Reiskörner -= Sushi.SushiValue;
            Sushi.SushiAnzahl++;
            Sushi.SushiValue = (int)(Mathf.Log(Sushi.SushiAnzahl + 1, 10) * 1000 + 250);
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            Sushi.SushiProSekunde += SushiReisProUpgrade;
            
        }
    }

    public void StartAutoReisChickenrice()
    {
        if (ReisAnzahl.Reiskörner >= (long)Chickenrice.chickenriceValue)
        {
            AutoReis.SetActive(true);
            ReisAnzahl.Reiskörner -= Chickenrice.chickenriceValue;
            Chickenrice.chickenriceAnzahl++;
            Chickenrice.chickenriceValue = (int)(Mathf.Log(Chickenrice.chickenriceAnzahl + 1, 10) * 1000 + 750);                   
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            Chickenrice.chickenriceProSekunde += ChickenriceReisProUpgrade;
          
        }
    }

    public void ReisProKlickVerbessern()
    {
        if (ReisAnzahl.Reiskörner >= (long)ReisProKlick.ReisProKlickValue)
        {
            ReisAnzahl.Reiskörner -= ReisProKlick.ReisProKlickValue;
            ReisProKlick.ReisProKlickStufe++;
            ReisProKlick.ReisProKlickValue = (int)(Mathf.Log(ReisProKlick.ReisProKlickStufe + 1, 10) * 1000 + 5);
            Reiskocher.KnopfAusschalten = true;
            Sushi.KnopfAusschalten = true;
            Chickenrice.KnopfAusschalten = true;
            ReisProKlick.KnopfAusschalten = true;
            Klickfunktion.ReisProKlick += ReisProKlickReisProUpgrade;
        }
    }

    public void NichtGenugReisAnimation()
    {    
            statusBox.GetComponent<TextMeshProUGUI>().text = "Nicht genügend Reis";
            statusBox.GetComponent<Animation>().Play("StatusAnimation");
    }
}
