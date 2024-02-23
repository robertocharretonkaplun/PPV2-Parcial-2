using UnityEngine;

public class MovimientoConFisica : MonoBehaviour
{
  public float velocidad = 5f;  // Velocidad de movimiento
  private Rigidbody2D rb;

  void Start()
  {
    // Obtener el componente Rigidbody2D del objeto
    rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    // Obtener la entrada del teclado
    float movimientoHorizontal = Input.GetAxis("Horizontal");

    // Calcular el vector de velocidad
    Vector2 velocidadMovimiento = new Vector2(movimientoHorizontal * velocidad, rb.velocity.y);

    // Aplicar la velocidad al Rigidbody2D
    rb.velocity = velocidadMovimiento;
  }
}
