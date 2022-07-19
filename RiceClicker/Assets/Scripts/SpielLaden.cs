using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpielLaden : MonoBehaviour
{
    public GameObject AutoR;
     

    void Start()
    {
        AutoR.SetActive(false);
        AutoReis.ReisErstellen = false;

        if (HauptmenüOptionen.imLadevorgang)
        {

            ReisAnzahl.Reiskörner = long.Parse(PlayerPrefs.GetString("GespeicherterReis"));

            Reiskocher.ReiskocherAnzahl = PlayerPrefs.GetInt("GespeicherteReiskocher");
            Reiskocher.ReiskocherValue = PlayerPrefs.GetInt("GReiskocherValue");
            Reiskocher.ReiskocherProSekunde = PlayerPrefs.GetInt("GRPSReiskocher");


            Sushi.SushiAnzahl = PlayerPrefs.GetInt("GespeichertesSushi");
            Sushi.SushiValue = PlayerPrefs.GetInt("GSushiValue");
            Sushi.SushiProSekunde = PlayerPrefs.GetInt("GRPSSushi");

            Chickenrice.chickenriceAnzahl = PlayerPrefs.GetInt("GespeicherterChickenrice");
            Chickenrice.chickenriceValue = PlayerPrefs.GetInt("GChickenriceValue");
            Chickenrice.chickenriceProSekunde = PlayerPrefs.GetInt("GRPSchickenrice");



            Klickfunktion.ReisProKlick = PlayerPrefs.GetInt("GespeicherterReisProKlick");
            ReisProKlick.ReisProKlickValue = PlayerPrefs.GetInt("GReisProKlickValue");
            ReisProKlick.ReisProKlickStufe = PlayerPrefs.GetInt("GReisProKlickStufe");

            if (Reiskocher.ReiskocherAnzahl != 0 || Sushi.SushiAnzahl != 0 || Chickenrice.chickenriceAnzahl != 0)
            {
                AutoR.SetActive(true);
                AutoReis.ReisErstellen = false;
            }
            HauptmenüOptionen.imLadevorgang = false;
        }
    }

}
