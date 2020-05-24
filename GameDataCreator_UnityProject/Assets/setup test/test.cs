using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDataCreator;

public class test : MonoBehaviour
{
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
