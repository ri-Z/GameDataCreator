using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace GameDataCreator
{
    public class Class1 : EditorWindow
    {
        string SchemaName = "";
        int nameDefaultCounter = 0;

        [MenuItem("Window/GameDataCreator")]
        public static void ShowWindow()
        {
            GetWindow<Class1>("GameDataCreator");
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
                }
                else if(SchemaName == "")
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


        //--------------------------------------------------------------------------------
        public int c;

        public void AddValues(int a, int b)
        {
            c = a + b;
        }

        public static int GenerateRandom(int min, int max)
        {
            System.Random rand = new System.Random();
            return rand.Next(min, max);
        }

        public void RenameObject(GameObject go, string name)
        {
            go.name = name;
        }
    }
}
