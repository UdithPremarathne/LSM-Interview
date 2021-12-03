using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyProgress
{
    public int MoneyCount { get; set; }
}

public class SkinProgress
{
    public RuntimeAnimatorController AnimController { get; set; }
}

public class PlayerProgress : MonoBehaviour
{
    private static readonly MoneyProgress moneyProgressInstance = new MoneyProgress();
    private static readonly SkinProgress skinProgressInstance = new SkinProgress();

    static PlayerProgress()
    {
    }

    private PlayerProgress()
    {
    }

    public static object Instance
    {
        get
        {
            return new { MoneyProgress = moneyProgressInstance
                , SkinProgress = skinProgressInstance };
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
