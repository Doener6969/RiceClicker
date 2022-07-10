using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoReis : MonoBehaviour {
    public static bool ReisErstellen = false;
    public static int ReisErh�hen = 1;
    public int InternalIncrease;


    void Update()
    {
        ReisErh�hen = Reiskocher.ReiskocherProSekunde + Sushi.SushiProSekunde + Chickenrice.chickenriceProSekunde;
        InternalIncrease = ReisErh�hen;
        if(ReisErstellen == false) 
        {
            ReisErstellen = true;
            StartCoroutine(ErstelleDenReis());
        }
    }
    IEnumerator ErstelleDenReis()
    {
        ReisAnzahl.Reisk�rner += InternalIncrease;
        yield return new WaitForSeconds(1);
        ReisErstellen = false;
    }
}
