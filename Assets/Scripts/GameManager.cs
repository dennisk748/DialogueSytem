using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DialogueBoxController dialogueBoxController;
    private static GameManager instance;

    public static GameManager Instance {
        get
        {
            if (instance == null)
            instance = GameObject.FindObjectOfType<GameManager>();
            return instance;
        }
    }
}
