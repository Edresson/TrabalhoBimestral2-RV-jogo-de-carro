using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonResetController : MonoBehaviour
{
    public void Reiniciar()
    {
        Scene cena = SceneManager.GetActiveScene();
        SceneManager.LoadScene(cena.name);
    }
}
