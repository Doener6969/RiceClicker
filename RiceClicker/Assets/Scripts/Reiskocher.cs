using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reiskocher : MonoBehaviour
{
    public GameObject falscherKnopf;
    public GameObject falscherText;
    public GameObject echterKnopf;
    public GameObject echterText;
    public int aktuellerReis;
    void Start()
    {
        
    }


    void Update()
    {
        aktuellerReis = ReisAnzahl.Reiskörner;
        if(aktuellerReis >= 69)
        {
            falscherKnopf.SetActive(false);
            echterKnopf.SetActive(true);
        }
    }
}
