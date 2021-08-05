#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class DisplayMessageOnLoad
{
    static DisplayMessageOnLoad()
    {
        Debug.Log("Hello, world!");
    }
}
#endif
