using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Subject", menuName = "ScriptableObjects/New_Lesson", order = 1)]
[System.Serializable]
public class Subject : ScriptableObject
{
  [Header("GameObject Configuration")]
  [SerializeField]
  public int Lesson = 0;
  
  [Header("Lession Quest Configuration")]
  [SerializeField]
  public List<Leccion> leccionList;
}
