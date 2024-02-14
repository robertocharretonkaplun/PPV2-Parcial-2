using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
  public int ActiveSlot = 0;
  public Transform Slots;
  public Transform[] InventorySlots;

  // Start is called before the first frame update
  void Start()
  {
    InventorySlots = Slots.GetComponentsInChildren<Transform>();
    // Convertir el arreglo en una lista para poder usar el método RemoveAt
    List<Transform> slotList = new List<Transform>(InventorySlots);

    // Eliminar el primer elemento de la lista
    slotList.RemoveAt(0);

    // Convertir la lista de nuevo en un arreglo
    InventorySlots = slotList.ToArray();
    // Configurar el slot activo inicial
    SetActiveSlot(ActiveSlot);
  }

  // Update is called once per frame
  void Update()
  {
    // Verificar las teclas de flecha para cambiar el slot activo
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      ChangeActiveSlot(-1); // Mover hacia la izquierda
    }
    else if (Input.GetKeyDown(KeyCode.RightArrow))
    {
      ChangeActiveSlot(1); // Mover hacia la derecha
    }
  }

  // Función para establecer el slot activo
  void SetActiveSlot(int newActiveSlot)
  {
    // Desactivar todos los slots
    foreach (Transform slot in InventorySlots)
    {
      slot.GetChild(0).gameObject.SetActive(false);
    }

    // Asegurarse de que el nuevo índice esté dentro del rango válido
    ActiveSlot = Mathf.Clamp(newActiveSlot, 0, InventorySlots.Length - 1);

    // Activar el nuevo slot
    InventorySlots[ActiveSlot].GetChild(0).gameObject.SetActive(true);
  }

  // Función para cambiar el slot activo en una dirección específica
  void ChangeActiveSlot(int direction)
  {
    SetActiveSlot(ActiveSlot + direction);
  }
}
