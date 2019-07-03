using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private int carroIndice = 0;
    public GameObject player;
    public bool menuInicial = true;
    public bool menuSelecionarCarro = false;
    public bool menuSelecionarCor = false;

    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;

    // Start is called before the first frame update
    void Start()
    {
        Canvas1.SetActive(true);
        Canvas2.SetActive(false);
        Canvas3.SetActive(false);
    }

    public void AtivaSelecionarCarro()
    {
        Canvas1.SetActive(false);
        Canvas2.SetActive(true);
        Canvas3.SetActive(false);
    }

    public void AtivaSelecionarDificuldade()
    {
        Canvas1.SetActive(false);
        Canvas2.SetActive(false);
        Canvas3.SetActive(true);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void IniciarJooj()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void ProximoCarro()
    {
        if (carroIndice >= player.GetComponent<CarChoiceController>().carCount)
            carroIndice = 0;
        else
            carroIndice += 1;

        player.GetComponent<CarChoiceController>().SelecionarCarro(carroIndice);
    }

    public void CarroAnterior()
    {
        if (carroIndice <= 0)
            carroIndice = player.GetComponent<CarChoiceController>().carCount;
        else
            carroIndice -= 1;

        player.GetComponent<CarChoiceController>().SelecionarCarro(carroIndice);
    }

    public void SetDificuldadeMtoFacil() {
        PlayerPrefs.SetString("Dificuldade", "MuitoFacil");
        IniciarJooj();
    }
    public void SetDificuldadeFacil() {
        PlayerPrefs.SetString("Dificuldade", "Facil");
        IniciarJooj();
    }
    public void SetDificuldadeMedio() {
        PlayerPrefs.SetString("Dificuldade", "Medio");
        IniciarJooj();
    }
    public void SetDificuldadeDificil() {
        PlayerPrefs.SetString("Dificuldade", "Dificil");
        IniciarJooj();
    }
}
