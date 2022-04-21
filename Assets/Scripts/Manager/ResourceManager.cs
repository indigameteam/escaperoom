using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    [SerializeField]
    private ResourceDictionary _resources;

    public Object GetResource(string key)
    {
        if(false == _resources.ContainsKey(key))
        {
            Debug.LogError($"Failed Get Prefab! Key : {key}");
            return null;
        }

        return _resources[key];
    }

    private ResourceManager() { }
}
