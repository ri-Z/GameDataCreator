using UnityEngine;
using UnityEditor;

public class ToggleGroupExample : EditorWindow
{
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    float myFloat = 1.23f;

    int _selected = 0;
    string[] _options = new string[3] { "Item1", "Item2", "Item3" };

    // Add menu named "ToggleGroupExample" to the Window menu
    [MenuItem("Window/ToggleGroupExample")]
    static void Init()
    {
        // Get existing open window or if none, make a new one:
        ToggleGroupExample window = (ToggleGroupExample)EditorWindow.GetWindow(typeof(ToggleGroupExample));
        window.Show();
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);
        myString = EditorGUILayout.TextField("Text Field", myString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider("Slider", myFloat, -3, 3);
        EditorGUILayout.EndToggleGroup();



        EditorGUI.BeginChangeCheck();
        this._selected = EditorGUILayout.Popup("My Simple Dropdown", _selected, _options);
        if (EditorGUI.EndChangeCheck())
        {
            Debug.Log(_options[_selected]);
        }

    }
}
