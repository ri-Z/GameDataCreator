﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class ScriptableObjectss : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public int manaCost;
    public int attack;
    public int hp;
}
