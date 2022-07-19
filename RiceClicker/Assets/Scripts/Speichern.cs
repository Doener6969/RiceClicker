using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpielSpeichern : MonoBehaviour
{   
    
    public void Speichern()
    {
        PlayerPrefs.SetString("GespeicherterReis", ReisAnzahl.Reiskörner.ToString());

        PlayerPrefs.SetInt("GespeicherteReiskocher", Reiskocher.ReiskocherAnzahl);
        PlayerPrefs.SetInt("GReiskocherValue", Reiskocher.ReiskocherValue);
        PlayerPrefs.SetInt("GRPSReiskocher", Reiskocher.ReiskocherProSekunde);

        PlayerPrefs.SetInt("GespeichertesSushi", Sushi.SushiAnzahl);
        PlayerPrefs.SetInt("GSushiValue", Sushi.SushiValue);
        PlayerPrefs.SetInt("GRPSSushi", Sushi.SushiProSekunde);


        PlayerPrefs.SetInt("GespeicherterChickenrice", Chickenrice.chickenriceAnzahl);
        PlayerPrefs.SetInt("GChickenriceValue", Chickenrice.chickenriceValue);
        PlayerPrefs.SetInt("GRPSchickenrice", Chickenrice.chickenriceProSekunde);


        PlayerPrefs.SetInt("GespeicherterReisProKlick", Klickfunktion.ReisProKlick);


    }
}
