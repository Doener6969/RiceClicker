using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HauptmenüOptionen : MonoBehaviour
{
    public static bool imLadevorgang = false;
    public long Reis;
    public int ReiskocherA;
    public int SushiA;
    public int ChickenriceA;
    public int ReisProKlickS;
    public GameObject statusMeldung;

    public void NeuesSpiel()
    {
        SceneManager.LoadScene(1);
        ReisAnzahl.Reiskörner = 0;
        Reiskocher.ReiskocherAnzahl = 0;
        Reiskocher.ReiskocherValue = 69;
        Reiskocher.ReiskocherProSekunde = 0;

        Sushi.SushiAnzahl = 0;
        Sushi.SushiValue = 250;
        Sushi.SushiProSekunde = 0;

        Chickenrice.chickenriceAnzahl = 0;
        Chickenrice.chickenriceValue = 750;
        Chickenrice.chickenriceProSekunde = 0;

        Klickfunktion.ReisProKlick = 1;
        ReisProKlick.ReisProKlickValue = 5;
        ReisProKlick.ReisProKlickStufe = 1;

    }

    public void SpielLaden()
    {
        Reis = long.Parse(PlayerPrefs.GetString("GespeicherterReis"));
        ReiskocherA = PlayerPrefs.GetInt("GespeicherteReiskocher");
        SushiA = PlayerPrefs.GetInt("GespeichertesSushi");
        ChickenriceA = PlayerPrefs.GetInt("GespeicherterChickenrice");
        ReisProKlickS = PlayerPrefs.GetInt("GespeicherterReisProKlick");
        if (Reis > 0 || ReiskocherA > 0 || SushiA > 0 || ChickenriceA > 0 || ReisProKlickS > 1)
        {
            imLadevorgang = true;
            SceneManager.LoadScene(1);
        }
        else
        {
            statusMeldung.GetComponent<TextMeshProUGUI>().text = "Kein Speicherstand verhanden";
            statusMeldung.GetComponent<Animation>().Play("StatusAnimation");
        }
        
    }
}
