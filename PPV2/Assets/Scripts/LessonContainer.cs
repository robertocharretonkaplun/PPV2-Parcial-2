using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonContainer : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void EnableWindow()
  {
    if (gameObject.activeSelf)
    {
      // Desactiva el objeto si est� activo
      gameObject.SetActive(false);
    }
    else
    {
      // Activa el objeto si est� desactivado
      gameObject.SetActive(true);
    }
  }
}
