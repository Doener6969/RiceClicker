using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZurückZumHauptmenü : MonoBehaviour
{
    public void ZumHauptmenüWechseln()
    {
        SceneManager.LoadScene(0);
    }
}
