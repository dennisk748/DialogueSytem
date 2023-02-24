using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using TMPro;
using UnityEngine;

public class DialogueBoxController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Dialogue dialogue;

    [Header("Text Mesh Pro")]
    [SerializeField] TextMeshProUGUI nameMesh;
    [SerializeField] TextMeshProUGUI textMesh;

    public static bool m_activated;
    private string[] characterDialogue;
    private DialogueTriggerEvent dialogueTrigger;
    private string fileName;
    private int m_index = 0;


    void Update()
    {
        if (m_activated)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) && m_index < characterDialogue.Length)
            {
                m_index++;
            }
        }
        
    }

    public void Appear(string fName, string characterName, DialogueTriggerEvent dTrigger)
    {
        dialogueTrigger = dTrigger;
        fileName = fName;

        nameMesh.text = characterName;
        characterDialogue = dialogue.dialogue[fileName];

        Debug.Log("1." + characterDialogue[0]);

        m_activated = true;

        StartCoroutine(Advance());
    }

    IEnumerator Advance()
    {
        textMesh.text = characterDialogue[m_index];

        yield return new WaitForSeconds(.4f);
    }
}
