using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ReisAnzahl : MonoBehaviour
{
    public static int Reiskörner;
    public GameObject ReisAnzeige;
    public int ReisKörnerAnzahl;

    void Update()
    {
        ReisKörnerAnzahl = Reiskörner;
        ReisAnzeige.GetComponent<TextMeshProUGUI>().text = "Reiskörner: " + ReisKörnerAnzahl;
    }
}
