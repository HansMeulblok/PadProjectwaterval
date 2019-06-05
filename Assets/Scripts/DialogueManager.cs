using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;           // naam van karakter
    public Text dialogueText;       // dialoog voor karakter

    public Animator animator;       // pop up van spraak wolk  

    private Queue<string> sentences;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();        // nieuwe queue aan dialoog dat bewerkt kan worden in de editor

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);       // zet de dialoog zinnen in de queue
        }

        DisplayNextSentence();              // de volgende zin weergeven zodra hij aangeroepen word
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)                   // de dialoog eindigen als er geen zinnen meer in de queue staan
        {
            EndDialogue();
          
            return;
        }

        string sentence = sentences.Dequeue();    
        StopAllCoroutines();                     // stopt de hele dialoog
        StartCoroutine(TypeSentence(sentence));
    }

   

    IEnumerator TypeSentence (string sentence)
        {
        dialogueText.text = "";                              // zorgt ervoor dat de zinnen in de queue letter voor letter worden weergeven. 
        foreach (char letter in sentence.ToCharArray()) 
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.001f);
        }
        }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);                   // stopt de animatie wanneer de dialoog aaf is. 
    }

    
}

