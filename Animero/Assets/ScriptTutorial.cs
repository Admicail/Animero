using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptTutorial : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;

    private float timetyping = 0.05f;
    private bool isPLayerInRange;
    private bool didDialogueStart;
    private int lineIndex;

    void Update()
    {
        if (isPLayerInRange)
        {
            if (!didDialogueStart)
            {
                StartDialogue();
            }
        }
    }
    private void StartDialogue()
    {
        didDialogueStart = true;
        lineIndex = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;
        foreach (char line in dialogueLines[lineIndex])
        {
            dialogueText.text += line;
            yield return new WaitForSecondsRealtime(timetyping);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPLayerInRange = true;
            dialoguePanel.SetActive(true);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPLayerInRange = false;
            dialoguePanel.SetActive(false);

        }
    }
}
