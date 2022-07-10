using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielSpeichern : MonoBehaviour
{   
    
    public void Speichern()
    {
        PlayerPrefs.SetInt("GespeicherterReis", ReisAnzahl.Reiskörner);
        PlayerPrefs.SetInt("GespeicherteReiskocher", Reiskocher.ReiskocherAnzahl);
        PlayerPrefs.SetInt("GespeichertesSushi", Sushi.SushiAnzahl);
        PlayerPrefs.SetInt("GespeicherterChickenrice", Chickenrice.chickenriceAnzahl);
        PlayerPrefs.SetInt("GespeicherterReisProKlick", Klickfunktion.ReisProKlick);
    }
}
