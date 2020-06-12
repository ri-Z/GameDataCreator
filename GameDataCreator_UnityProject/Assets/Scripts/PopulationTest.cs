using UnityEngine;
using UnityEditor;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class PopulationTest : MonoBehaviour
{
    public bool Populate;
    public fogo[] data;

    private void Start()
    {
        //data[0].hp = 10000;
        ////AssetDatabase.SaveAssets();
        //AssetDatabase.Refresh();
        //FieldInfo[] fields = data.GetType().GetFields();
        //fields[1].SetValue(data, Convert.ChangeType(10, typeof(Int32)));
        //Debug.Log();
        //Debug.Log("data[0].manaCost = " + data[0].manaCost + "data[0].hp = " + data[0].hp + "data[0].attack = " + data[0].attack);
        data[0].manaCost = 1;
        data[0].hp = 2;
        data[0].attack = 3;
    }
    private void OnValidate()
    {
        if (Populate)
        {
            if (data != null)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != null)
                    {
                        //data[i].manaCost = 1;
                        //data[i].hp = 2;
                        //data[i].attack = 3;
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        FileStream file = File.Create(Application.persistentDataPath + string.Format("/{0}.pso", i));
                        var json = JsonUtility.ToJson(data[i]);
                        binaryFormatter.Serialize(file, json);
                        file.Close();

                        if (File.Exists(Application.persistentDataPath + string.Format("/{0}.pso", i)))
                        {
                            file = File.Open(Application.persistentDataPath + string.Format("/{0}.pso", i), FileMode.Open);
                            JsonUtility.FromJsonOverwrite((string)binaryFormatter.Deserialize(file), data[i]);
                            file.Close();
                            // writing changes of the testScriptable into Undo
                            Undo.RecordObject(data[i], "Changed Data");
                            // mark the ScriptableObject object as "dirty" and save it
                            EditorUtility.SetDirty(data[i]);
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
                Populate = false;
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
            Debug.Log("data[0].manaCost = " + data[0].manaCost + "data[0].hp = " + data[0].hp + "data[0].attack = " + data[0].attack);
        }
    }
}
