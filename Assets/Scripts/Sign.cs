using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : Interactable    
{
    public GameObject dialogbox;
    public Text dialogText;
    public string dialog;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        {
            FindObjectOfType<AudioManager>().Play("Open");
            if (dialogbox.activeInHierarchy)
            {
                dialogbox.SetActive(false);
            }
            else
            {
                dialogbox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collsion)
    {
        if (collsion.CompareTag("Player") && !collsion.isTrigger)
        {
            // context is used for enabling the clue Signal
            context.Raise();
            playerInRange = false;
            dialogbox.SetActive(false);
        }
    }
}
