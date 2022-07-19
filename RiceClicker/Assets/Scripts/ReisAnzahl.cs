using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReisAnzahl : MonoBehaviour
{
    public static long Reiskörner;
    public GameObject ReisAnzeige;
    public long ReisKörnerAnzahl;

    void Update()
    {
        ReisKörnerAnzahl = Reiskörner;
        ReisAnzeige.GetComponent<TextMeshProUGUI>().text = "Reiskörner: " + ReisKörnerAnzahl;
    }
}
