using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogtext;
    public GameObject textBox;

    private Queue<string> sentences;
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(Dialog dialog)
    {
        nameText.text = dialog.name;

        sentences.Clear();

        foreach( string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentece();
    }

    public void DisplayNextSentece()
    {
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
        }

        string sentece = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentece(sentece));
    }

    IEnumerator TypeSentece (string sentece)
    {
        dialogtext.text = "";
        //loop throgh the indivial characters in the sentece
        foreach(char letter in sentece.ToCharArray())
        {
            dialogtext.text += letter;
            yield return null;
        }
    }

    void EndDialog()
    {
        Debug.Log("End of conversation");
        textBox.SetActive(false);
    }
}
