using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueTriggerEvent : MonoBehaviour
{
    [Header("Trigger")]
    [SerializeField] private bool m_autoHit; //Does the player need to press the interact button, or will it simply fire automatically?
    [SerializeField] private string m_characterName; //The character's name shown in the dialogue UI
    [SerializeField] private GameObject m_characterDialogueBox;

    public UnityEvent onTriggerEnter = new UnityEvent();
    public UnityEvent onTriggerExit = new UnityEvent();

    [SerializeField] private string dialogueStringA;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) onTriggerEnter.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) onTriggerExit.Invoke();
    }

    public void Appear()
    {
        Debug.Log("You are Interacting with an NPC");
        m_characterDialogueBox.SetActive(true);
        if (m_autoHit || (Input.GetAxis("Submit") > 0))
        {
            GameManager.Instance.dialogueBoxController.Appear(dialogueStringA, m_characterName, this);
        }    
    }

    public void Close()
    {
        m_characterDialogueBox.SetActive(false);
    }
}
