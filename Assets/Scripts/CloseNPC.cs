using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseNPC : MonoBehaviour
{
    public GameObject canvasDialogue;

    public void CloseDialogue()
    {
        canvasDialogue.SetActive(false);
    }
}
