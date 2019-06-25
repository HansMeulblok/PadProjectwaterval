using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;


    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        sentences = new Queue<string>();
=======
        sentences = new Queue<string>(); 
>>>>>>> parent of c5a2a7b... Vertaling
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

<<<<<<< HEAD
        nameText.text = dialogue.name;

        sentences.Clear();
        sentences = new Queue<string>();        // nieuwe queue aan dialoog dat bewerkt kan worden in de editor
=======
        nameText.text = dialogue.name; 

        sentences.Clear();
>>>>>>> parent of c5a2a7b... Vertaling

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
          
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

   

    IEnumerator TypeSentence (string sentence)
        {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) 
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(.001f);
        }
        }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }

    
}

