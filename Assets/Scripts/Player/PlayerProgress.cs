using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyProgress
{
    public int MoneyCount { get; set; }
}

public class PlayerProgress : MonoBehaviour
{
    private static readonly MoneyProgress instance = new MoneyProgress();
    static PlayerProgress()
    {
    }
    private PlayerProgress()
    {
    }
    public static MoneyProgress Instance
    {
        get
        {
            return instance;
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
