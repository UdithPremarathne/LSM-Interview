using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;


    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TriggerDialog();
            

        }
    }
}
