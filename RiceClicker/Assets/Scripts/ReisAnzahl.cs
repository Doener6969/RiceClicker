using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReisAnzahl : MonoBehaviour
{
    public static long Reisk�rner;
    public GameObject ReisAnzeige;
    public long ReisK�rnerAnzahl;

    void Update()
    {
        ReisK�rnerAnzahl = Reisk�rner;
        ReisAnzeige.GetComponent<TextMeshProUGUI>().text = "Reisk�rner: " + ReisK�rnerAnzahl;
    }
}
