using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speichern : MonoBehaviour
{   
    
    public void SpielSpeichern()
    {
        PlayerPrefs.SetInt("GespeicherterReis", ReisAnzahl.Reisk�rner);
        PlayerPrefs.SetInt("GespeicherteReiskocher", Reiskocher.ReiskocherAnzahl);
        PlayerPrefs.SetInt("GespeichertesSushi", Sushi.SushiAnzahl);
        PlayerPrefs.SetInt("GespeicherterChickenrice", Chickenrice.chickenriceAnzahl);
        PlayerPrefs.SetInt("GespeicherterReisProKlick", Klickfunktion.ReisProKlick);
    }
}
