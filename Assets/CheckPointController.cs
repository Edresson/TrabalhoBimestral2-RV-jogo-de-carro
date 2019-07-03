using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    public int index;
    void OnTriggerEnter()
    {
        RaceController RaceController = transform.parent.GetComponent<RaceController>();

        if (RaceController != null) {
            RaceController.CompletaCheckpoint(index);
        }
    }
}
