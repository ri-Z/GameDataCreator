using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDataCreator;
using UnityEditor.ProjectWindowCallback;
using System;
using System.Linq;
using System.Reflection;


public class test : MonoBehaviour
{

    //public static string[] names;

    //public static Type[] types;

    //public static Type[] Types
    //{
    //    get { return types; }
    //    set
    //    {
    //        types = value;
    //        names = types.Select(t => t.FullName).ToArray();
    //    }
    //}

    void Start()
    {
        Class1 utils = new Class1();
        utils.AddValues(2, 3);
        print("2 + 3 = " + utils.c);
        utils.RenameObject(this.gameObject, "Jorge");
    }

    void Update()
    {
        print(Class1.GenerateRandom(0, 100));
    }
}
