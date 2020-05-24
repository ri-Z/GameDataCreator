using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomshit : MonoBehaviour
{
    private System.Random random;
    void Start()
    {
        random = new System.Random();
        Debug.Log("random: " + random);
    }
}
