using UnityEngine;
using UnityEditor;

public class YourClassAsset
{
    [MenuItem("Assets/Create/ScriptableObjects")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<ScriptableObjectss>();
    }
}