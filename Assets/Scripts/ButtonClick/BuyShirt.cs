using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyShirt : MonoBehaviour
{
    public Animator animator;
    public RuntimeAnimatorController animController;

    private static readonly object mp = PlayerProgress
        .Instance.GetType().GetProperty(Globals.PROGRESS_TYPE_MONEY)
        .GetValue(PlayerProgress.Instance, null);
    private static readonly object sp = PlayerProgress
        .Instance.GetType().GetProperty(Globals.PROGRESS_TYPE_SKIN)
        .GetValue(PlayerProgress.Instance, null);

    // get singleton instance for player progress fields
    readonly MoneyProgress moneyProgress = (MoneyProgress)mp;
    readonly SkinProgress skinProgress = (SkinProgress)sp;

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
        if (moneyProgress.MoneyCount > 0)
        {
            
            int localCount = moneyProgress.MoneyCount;
            moneyProgress.MoneyCount = localCount - Globals.RED_SHIRT_VALUE;
            MoneyTextManager.instance.DeductFromScore(Globals.RED_SHIRT_VALUE);
            Debug.Log(moneyProgress.MoneyCount);
            animator.runtimeAnimatorController = animController;
            skinProgress.AnimController = animController;
            FindObjectOfType<AudioManager>().Play("Money");
        } 
        else
        {
            Debug.Log("Not enough money dialog box");
        }
    }
}
