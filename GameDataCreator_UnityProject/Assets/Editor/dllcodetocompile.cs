using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class dllcodetocompile : EditorWindow
{
    //public List<string> Schemas = new List<string>();
    //string SchemaName = "";
    //int nameDefaultCounter = 0;

    //int VariableTypeSelected = 0;
    //string[] VariableTypeOptions = new string[] { "Bool", "Int", "Float" };
    //string Variable = "";


    List<Data1Test> datas = new List<Data1Test>();
    Data1Test data1Test = new Data1Test();

    [MenuItem("Window/GameDataCreator_ToCompile")]
    public static void ShowWindow()
    {
        GetWindow<dllcodetocompile>("GameDataCreator_ToCompile");
    }

    void OnGUI()
    {
        //// Window Code
        //EditorGUILayout.BeginHorizontal();
        //SchemaName = EditorGUILayout.TextField("Schema Name: ", SchemaName);
        //if (GUILayout.Button("Create New Schema"))
        //{
        //    if (SchemaName != "")
        //    {
        //        Debug.Log("New Schema Created! - " + SchemaName);
        //        for (int i = 0; i < Schemas.Count; i++)
        //        {
        //            if (SchemaName == Schemas[i]) // NOT WORKING
        //            {
        //                Debug.Log("Name already in use!");
        //            }
        //            else
        //            {
        //                Schemas.Add(SchemaName);
        //            }
        //        }
        //    }
        //    else if (SchemaName == "")
        //    {
        //        SchemaName = "DefaultName_" + nameDefaultCounter;
        //        Debug.Log("New Default Name Schema Created! - " + SchemaName);
        //        nameDefaultCounter++;
        //    }
        //}
        //EditorGUILayout.EndHorizontal();

        //EditorGUILayout.Space(); // Divisor


        //EditorGUILayout.BeginHorizontal();
        ////EditorGUILayout.LabelField("Schema List: ");
        //GUILayout.Label("Schema List: ", EditorStyles.boldLabel);
        //EditorGUILayout.EndHorizontal();
        //EditorGUILayout.BeginHorizontal();
        //ShowSchema();
        //EditorGUILayout.EndHorizontal();


        //EditorGUILayout.Space(); // Divisor

        ////////////////////////////////////////////////////////////////////////////////////////////////

        if (GUILayout.Button("Load CSV file"))
        {
            TextAsset data = Resources.Load<TextAsset>("data1");
            string[] rows = data.text.Split(new char[] { '\n' });
            //Debug.Log(rows.Length);
            //Debug.Log(rows[0]);



            // i = 2, because 1st and 2nd rows are variables types and names
            for (int i = 0; i < rows.Length - 1; i++)
            {
                string[] colum = rows[i].Split(new char[] { ';' });
                //Debug.Log("colum[0]: " + colum[0]);
                for (int j = 0; j < colum.Length; j++)
                {
                    //Debug.Log("rows[0]: " + rows[0] + " colum[0]: " + colum[0]);
                    var columItem = colum[i];

                    Debug.Log("columItem: " + columItem);
                    //if (rows[0] == "int" && colum[j] == "int")
                    //{
                    //    //int.Parse(colum[2]);// (colum[i], out );
                    //    int.TryParse(colum[2], out data1Test.id);
                    //    Debug.Log("colum[2]: " + colum[2]);
                    //}
                }

                //if (colum[0] != "")
                //{
                //    Data1Test data1Test = new Data1Test();
                //    int.TryParse(colum[0], out data1Test.id);
                //    data1Test.name = colum[1];
                //    float.TryParse(colum[2], out data1Test.hp);
                //    float.TryParse(colum[3], out data1Test.damage);
                //    bool.TryParse(colum[4], out data1Test.god);
                //    datas.Add(data1Test);
                //}

            }

            //foreach (var item in datas)
            //{
            //    Debug.Log(item.name);
            //}
        }
    }


    //void ShowSchema()
    //{
    //    EditorGUI.BeginChangeCheck();
    //    VariableTypeSelected = EditorGUILayout.Popup("Variable Type:", VariableTypeSelected, VariableTypeOptions);
    //    if (EditorGUI.EndChangeCheck())
    //    {
    //        Debug.Log(VariableTypeSelected);
    //        Debug.Log(VariableTypeOptions[VariableTypeSelected]);
    //    }

    //    Variable = EditorGUILayout.TextField("Variable Name: ", Variable);
    //    if (GUILayout.Button("Add Variable"))
    //    {

    //    }


    //    switch (VariableTypeSelected)
    //    {
    //        case 0:
    //            break;
    //        case 1:
    //            break;
    //        case 2:
    //            break;
    //        default:
    //            Debug.LogError("Unrecognized Option");
    //            break;
    //    }
    //}
}
