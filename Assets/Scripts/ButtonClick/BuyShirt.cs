using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyShirt : MonoBehaviour
{
    public Animator animator;
    public RuntimeAnimatorController redAnim;
    // get singleton instance for player progress fields
    MoneyProgress progress = PlayerProgress.Instance;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TestButtonClick()
    {
        if (progress.MoneyCount > 0)
        {
            Debug.Log(progress.MoneyCount);
            int localCount = progress.MoneyCount;
            progress.MoneyCount = localCount - Globals.RED_SHIRT_VALUE;
            MoneyTextManager.instance.DeductFromScore(Globals.RED_SHIRT_VALUE);
            Debug.Log(progress.MoneyCount);
            animator.runtimeAnimatorController = redAnim;
        } 
        else
        {
            // ubata behe ganna oka
            Debug.Log("Ubata ba");
        }
    }
}
