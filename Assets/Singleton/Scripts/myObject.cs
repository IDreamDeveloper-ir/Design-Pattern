using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myObject : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
