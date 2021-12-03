using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellFood : MonoBehaviour
{
    public Text qty , val;
    public int quantity;
    public int price;

    private static readonly object mp = PlayerProgress
        .Instance.GetType().GetProperty(Globals.PROGRESS_TYPE_MONEY)
        .GetValue(PlayerProgress.Instance, null);
    // get singleton instance for player progress fields
    readonly MoneyProgress moneyProgress = (MoneyProgress)mp;

    // Start is called before the first frame update
    void Start()
    {
        quantity = 3;
        price = Globals.FOOD_PRICE_VALUE;
        val.text = $"$ {price}";
        qty.text = $"X {quantity}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSellFood()
    {
        Debug.Log("Squantitiy : " + quantity);
        if (quantity > 0)
        {
            quantity--;
            qty.text = $"X {quantity}";
            moneyProgress.MoneyCount += price;
            MoneyTextManager.instance.AddToScore(price);
        }
    }
}
