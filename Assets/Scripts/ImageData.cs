using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Images Data", order = 1)]
public class ImageData : ScriptableObject
{
    public Texture image;
    public string title;
    public Vector3 position;
    public bool isPlanet; 
}
