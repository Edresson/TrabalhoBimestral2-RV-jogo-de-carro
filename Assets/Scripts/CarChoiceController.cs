using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoiceController : MonoBehaviour
{
    public GameObject carroSelecionado;
    public GameObject CamLookAtTarget;
    public GameObject CamPosition;
    public GameObject CamSidePosition;
    public int carCount;

    public void SelecionarCarro(int carro)
    {
        if (carro < transform.childCount)
        {
            // desativar todos os carros que nao foram selecionados
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject Go = transform.GetChild(i).gameObject;
                if (Go != null)
                    Go.SetActive(false);
            }

            carroSelecionado = transform.GetChild(carro).gameObject;

            if (carroSelecionado != null)
            {
                PlayerPrefs.SetInt("Carro", carro);
                carroSelecionado.SetActive(true);

                GameObject CamRig = carroSelecionado.transform.Find("CamRig").gameObject;

                if (CamRig != null)
                {
                    CamLookAtTarget = CamRig.transform.Find("CamLookAtTarget").gameObject;
                    CamPosition = CamRig.transform.Find("CamPosition").gameObject;
                    CamSidePosition = CamRig.transform.Find("CamSidePosition").gameObject;
                }
            }
            else
            {
                Debug.Log("Falha ao carregar o carro");
            }
        }
        else
        {
            Debug.Log("Indice Maior do que a quantidade de carros disponiveis");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        carCount = transform.childCount;
        if (transform.childCount > 0)
        {
            int carro = PlayerPrefs.GetInt("Carro", 0); 

            SelecionarCarro(carro);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
