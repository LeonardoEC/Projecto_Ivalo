using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Zombi", menuName = "Data/Zombi", order = 0)]
public class Zombi_data : ScriptableObject
{
    [SerializeField] public string nombreDelZombi;
    [SerializeField] public float velocidad;
}
