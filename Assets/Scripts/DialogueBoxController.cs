using System;
using System.Collections;
using System.Collections.Generic;
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
    private int m_cPos = 0;
    private string[] characterDialogue;
    private DialogueTriggerEvent dialogueTrigger;
    private string fileName;
    private int m_index = -1;
    private bool m_typing = true;


    void Update()
    {
        if (m_activated)
        {
            if ((Input.GetAxis("Submit") > 0) || (Input.GetAxis("Jump") > 0))
            {

            }
        }
        
    }

    public void Appear(string fName, string characterName, DialogueTriggerEvent dTrigger)
    {
        dialogueTrigger = dTrigger;
        fileName = fName;

        nameMesh.text = characterName;
        characterDialogue = dialogue.dialogue[fileName];

        m_activated = true;

        StartCoroutine(Advance());
    }

    IEnumerator Advance()
    {
        m_index++;
        m_typing = true;

        textMesh.text = "";
        StartCoroutine("TypeText");

        //Wait before typing
        yield return new WaitForSeconds(.4f);
    }

    IEnumerator TypeText()
    {
        WaitForSeconds wait = new WaitForSeconds(.01f);
        foreach (char c in characterDialogue[m_index])
        {
            m_cPos++;
            if (m_cPos != 0 && m_cPos == characterDialogue[m_index].Length)
            {
                m_typing = false;
                m_cPos = 0;
            }

            textMesh.text += c;
            yield return wait;
        }
    }
}
