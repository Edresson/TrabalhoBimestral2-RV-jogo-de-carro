using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextController : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoForward()
    {
        Scene cena = SceneManager.GetActiveScene();
        switch(cena.name) {
            case "Scene1":
                SceneManager.LoadScene("Scene2");
                break;
            case "Scene2":
                SceneManager.LoadScene("Scene3");
                break;
            case "Scene3":
                SceneManager.LoadScene("Scene1");
                break;
            default:
                SceneManager.LoadScene("Scene1");
                break;
        }
    }
}
