using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabeLoader : MonoBehaviour
{
    public static bool HasSpawn = false;
    [SerializeField] private GameObject prefab;

    private void Awake()
    {
        if (HasSpawn) return;

        Instantiate(prefab);

        HasSpawn = true;
    }
}
