using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHandler : MonoBehaviour
{
    private DialogueParser parser;

    // Start is called before the first frame update
    void Start()
    {
        parser = gameObject.GetComponent<DialogueParser>();
    }

    // Implement handling of the dialogue
}
