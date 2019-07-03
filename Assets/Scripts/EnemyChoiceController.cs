using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChoiceController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (transform.childCount > 0)
        {
            string dificuldade = PlayerPrefs.GetString("Dificuldade", "Facil"); 

            // desativa todos
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject Go = transform.GetChild(i).gameObject;
                if (Go != null) {
                    // se for igual ao nome da dificuldade ativa, senao desativa
                    Go.SetActive(Go.name.Equals(dificuldade));
                }
            }
        }
    }
}
