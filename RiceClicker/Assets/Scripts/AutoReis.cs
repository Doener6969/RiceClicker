using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoReis : MonoBehaviour {
    public static bool ReisErstellen = false;
    public static int ReisErhöhen = 1;
    public int InternalIncrease;


    void Update()
    {
        ReisErhöhen = Reiskocher.ReiskocherProSekunde + Sushi.SushiProSekunde + Chickenrice.chickenriceProSekunde;
        InternalIncrease = ReisErhöhen;
        if(ReisErstellen == false) 
        {
            ReisErstellen = true;
            StartCoroutine(ErstelleDenReis());
        }
    }
    IEnumerator ErstelleDenReis()
    {
        ReisAnzahl.Reiskörner += InternalIncrease;
        yield return new WaitForSeconds(1);
        ReisErstellen = false;
    }
}
