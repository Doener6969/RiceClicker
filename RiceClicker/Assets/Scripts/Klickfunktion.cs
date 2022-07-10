using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klickfunktion : MonoBehaviour
{
    public GameObject textBox;
    public static int ReisProKlick = 1;
    public void Klicken()
    {
        ReisAnzahl.Reiskörner += ReisProKlick;
    }
}
