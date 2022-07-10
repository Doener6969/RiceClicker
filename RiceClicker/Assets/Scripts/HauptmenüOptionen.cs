using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HauptmenüOptionen : MonoBehaviour
{
    public static bool imLadevorgang = false;

    public void NeuesSpiel()
    {
        SceneManager.LoadScene(1);
    }

    public void SpielLaden()
    {
        imLadevorgang = true;
        SceneManager.LoadScene(1);
    }
}
