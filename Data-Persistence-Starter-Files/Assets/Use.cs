using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Use : MonoBehaviour
{
    public static Use Instance;

    private void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this);
    }

    public string userName;
    public void SetName(string name)
    {
        userName = name;
    }
}
