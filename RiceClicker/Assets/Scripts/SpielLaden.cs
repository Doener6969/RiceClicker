using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpielLaden : MonoBehaviour
{
    public GameObject AutoReis;
     
    void Start()
    {
       if(Hauptmen�Optionen.imLadevorgang)
        {
            
            ReisAnzahl.Reisk�rner = PlayerPrefs.GetInt("GespeicherterReis");
            Reiskocher.ReiskocherAnzahl = PlayerPrefs.GetInt("GespeicherteReiskocher");
            Sushi.SushiAnzahl = PlayerPrefs.GetInt("GespeichertesSushi");
            Chickenrice.chickenriceAnzahl = PlayerPrefs.GetInt("GespeicherterChickenrice");
            Klickfunktion.ReisProKlick = PlayerPrefs.GetInt("GespeicherterReisProKlick");
            if (Reiskocher.ReiskocherAnzahl != 0)
            {
                Reiskocher.ReiskocherValue *= ((int)(Mathf.Pow(2, Reiskocher.ReiskocherAnzahl)));
                Reiskocher.ReiskocherProSekunde = K�ufe.ReiskocherReisProUpgrade * Reiskocher.ReiskocherAnzahl;
            }
            if (Sushi.SushiAnzahl != 0)
            {
                Sushi.SushiValue *= ((int)(Mathf.Pow(2, Sushi.SushiAnzahl)));
                Sushi.SushiProSekunde = K�ufe.SushiReisProUpgrade * Sushi.SushiAnzahl;
            }
            if (Chickenrice.chickenriceAnzahl != 0)
            {
                Chickenrice.chickenriceValue *= ((int)(Mathf.Pow(2, Chickenrice.chickenriceAnzahl)));
                Chickenrice.chickenriceProSekunde = K�ufe.ChickenriceReisProUpgrade * Chickenrice.chickenriceAnzahl;
            }
            if (Reiskocher.ReiskocherAnzahl != 0 || Sushi.SushiAnzahl != 0 || Chickenrice.chickenriceAnzahl != 0)
            {
                AutoReis.SetActive(true);
            }
            if(Klickfunktion.ReisProKlick > 1)
            {
                ReisProKlick.ReisProKlickStufe = ((int)(Mathf.Ceil(Klickfunktion.ReisProKlick / K�ufe.ReisProKlickReisProUpgrade)))+1;
                ReisProKlick.ReisProKlickValue *= ((int)(Mathf.Pow(2, (ReisProKlick.ReisProKlickStufe-1))));
            }
        }
    }

}
