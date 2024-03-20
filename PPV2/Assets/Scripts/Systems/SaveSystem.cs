using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveSystem : MonoBehaviour
{
  public static SaveSystem instance;

  public Leccion data;
  public SubjectContainer subject;
  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  private void Start()
  {
    SaveToJSON("LeccionDummy", data);
    //SaveToJSON("SubjectDummy", subject);

    subject = LoadFromJSON<SubjectContainer>("SubjectDummy");
  }

  /// <summary>
  /// Esta funcion esta encargada de almacenar objetos en archivos JSON.
  /// </summary>
  /// <param name="_fileName"></param>
  /// <param name="_data"></param>
  public void SaveToJSON(string _fileName, object _data)
  {
    if (_data != null)
    {
      string JSONData = JsonUtility.ToJson(_data, true);

      if (JSONData.Length != 0)
      {
        Debug.Log("JSON STRING: " + JSONData);
        string fileName = _fileName + ".json";
        string filePath = Path.Combine(Application.dataPath + "/Resources/JSONS/", fileName);
        File.WriteAllText(filePath, JSONData);
        Debug.Log("JSON almacenado en la direccion: " + filePath);
      }
      else
      {
        Debug.LogWarning("ERROR - FileSystem: JSONData is empty, check for local variable [string JSONData]");
      }
    }
    else
    {
      Debug.LogWarning("ERROR - FileSystem: _data is null, check for param [object _data]");
    }
  }


  public T LoadFromJSON<T>(string _fileName) where T : new()
  {
    T Dato = new T();
    string path = Application.dataPath + "/Resources/JSONS/" + _fileName + ".json";
    string JSONData = "";
    if (File.Exists(path))
    {
      JSONData = File.ReadAllText(path);
      Debug.Log("JSON STRING: " + JSONData);
    }
    if (JSONData.Length != 0)
    {
      JsonUtility.FromJsonOverwrite(JSONData, Dato);
    }
    else
    {
        Debug.LogWarning("ERROR - FileSystem: JSONData is empty, check for local variable [string JSONData]");
    }
    return Dato;
  }
}
