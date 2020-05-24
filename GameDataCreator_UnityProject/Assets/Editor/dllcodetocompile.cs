using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class dllcodetocompile : EditorWindow
{
    public List<string> Schemas = new List<string>();
    string SchemaName = "";
    int nameDefaultCounter = 0;

    [MenuItem("Window/GameDataCreator_ToCompile")]
    public static void ShowWindow()
    {
        GetWindow<dllcodetocompile>("GameDataCreator_ToCompile");
    }

    void OnGUI()
    {
        // Window Code
        EditorGUILayout.BeginHorizontal();
        SchemaName = EditorGUILayout.TextField("Schema Name: ", SchemaName);
        if (GUILayout.Button("Create New Schema"))
        {
            if (SchemaName != "")
            {
                Debug.Log("New Schema Created! - " + SchemaName);
                Schemas.Add(SchemaName);
            }
            else if (SchemaName == "")
            {
                SchemaName = "DefaultName_" + nameDefaultCounter;
                Debug.Log("New Default Name Schema Created! - " + SchemaName);
                nameDefaultCounter++;
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(); // Divisor


        EditorGUILayout.BeginHorizontal();
        //EditorGUILayout.LabelField("Schema List: ");
        GUILayout.Label("Schema List: ", EditorStyles.boldLabel);


        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(); // Divisor
    }
}
