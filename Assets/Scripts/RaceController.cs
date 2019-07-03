using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceController : MonoBehaviour
{
    public int voltas = 0;

    public int totalVoltas = 2;

    public Text stringVoltas;

    public List<bool>  checkpoints;

    public void CompletaCheckpoint(int checkpoint)
    {
        checkpoints[checkpoint] = true;

        VerificaVolta();
    }

    public void VerificaVolta()
    {
        var completo = true;

        for (int i = 0; i < checkpoints.Count; i++)
        {
            completo = completo && checkpoints[i];
        }

        if (completo)
        {
            for (int i = 0; i < checkpoints.Count; i++)
            {
                checkpoints[i] = false;
            }
            voltas += 1;
            AtualizaTexto();

            if (voltas == totalVoltas) {
                FimDoJogo();
            }
        }
    }

    void FimDoJogo() {

    }

    void AtualizaTexto() {
        stringVoltas.text = "Voltas: " + voltas.ToString() + "/" + totalVoltas.ToString();

    }

    // Start is called before the first frame update
    void Start()
    {
        AtualizaTexto();

        for (int i = 0; i < transform.childCount; i++)
        {
            checkpoints.Add(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
