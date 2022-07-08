using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Käufe : MonoBehaviour
{
    public GameObject AutoReis;
    public void StartAutoReis()
    {
        AutoReis.SetActive(true);
        ReisAnzahl.Reiskörner -= Reiskocher.ReiskocherValue;
        Reiskocher.ReiskocherValue *= 2;
        Reiskocher.KnopfAusschalten = true;
        Reiskocher.ReiskocherProSekunde += 1;
        Reiskocher.ReiskocherAnzahl += 1;
    }
}
