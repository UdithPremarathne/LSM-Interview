using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyTextManager : MonoBehaviour
{
    public static MoneyTextManager instance;
    public TextMeshProUGUI text;
    private static readonly object mp = PlayerProgress
        .Instance.GetType().GetProperty(Globals.PROGRESS_TYPE_MONEY)
        .GetValue(PlayerProgress.Instance, null);

    // get singleton instance for player progress fields
    MoneyProgress moneyProgress = (MoneyProgress)mp;

    // scene specific notes count is initialized
    int count = 0;

    public void Start()
    {
        if(instance == null)
        {
            instance = this;
            count = moneyProgress.MoneyCount;
            text.text = $"{count}";
        }
    }

    public void AddToScore(int moneyValue)
    {
        count += moneyValue;
        moneyProgress.MoneyCount = count;
        text.text = (count.ToString());
    }

    public void DeductFromScore(int moneyValue)
    {
        count -= moneyValue;
        moneyProgress.MoneyCount = count;
        text.text = (count.ToString());
    }
}
