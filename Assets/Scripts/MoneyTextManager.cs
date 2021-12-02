using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyTextManager : MonoBehaviour
{
    public static MoneyTextManager instance;
    public TextMeshProUGUI text;
    // get singleton instance for player progress fields
    MoneyProgress progress = PlayerProgress.Instance;
    // scene specific notes count is initialized
    int count = 0;

    public void Start()
    {
        if(instance == null)
        {
            instance = this;
            count = progress.MoneyCount;
            text.text = $"{count}";
        }
    }

    public void AddToScore(int moneyValue)
    {
        count += moneyValue;
        progress.MoneyCount = count;
        text.text = (count.ToString());
    }

    public void DeductFromScore(int moneyValue)
    {
        count -= moneyValue;
        progress.MoneyCount = count;
        text.text = (count.ToString());
    }
}
