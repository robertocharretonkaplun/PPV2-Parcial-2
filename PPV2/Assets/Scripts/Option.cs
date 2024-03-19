using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Esta clase esta encargada de almacenar la respuesta correcta tanto en ID y en su nombre.
/// </summary>
public class Option : MonoBehaviour
{
  // Esta variable esta encargada de almacenar la respuesta individual de cada boton.
  public int OptionID;
  // Almacena el nombre de la respuesta
  public string OptionName;

  // Start is called before the first frame update
  void Start()
  {
    /* En esta seccion, estamos inicializando nuestra variable del nombre del boton.
       en la interfaz del usuario. */
    transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
  }

  /// <summary>
  /// Este metodo esta encargado de actualizar manualmente, el nombre visible en UI de las opciones.
  /// Este metodo se llama, cada vez que se cambia a la siguiente pregunta.
  /// </summary>
  public void UpdateText()
  {
    transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
  }

  /// <summary>
  /// Este metodo esta encargado, de determinar si el jugador selecciono la opcion,
  /// si es asi, el levelManager, actualizara la informacion de la respuesta del jugador y
  /// hara interactuable o no, el boton de comprobar.
  /// 
  /// Este metodo, se utiliza en el mismo gameobject, en el componente Button como
  /// un evento de click.
  /// 
  /// <c>
  /// NOTA: 
  /// </c>
  /// Si el metodo no se asigna al boton, el programa no podra registrar, si el jugador,
  /// presiono o no el boton.
  /// 
  /// </summary>
  public void SelectOption()
  {
    LevelManager.Instance.SetPlayerAnswer(OptionID);
    LevelManager.Instance.CheckPlayerState();
  }
}
