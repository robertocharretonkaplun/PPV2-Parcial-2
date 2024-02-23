using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
  public Transform target;
  public float speed = 5f;
  public bool playerTouch = false;
  // Start is called before the first frame update
  void Start()
  {
    Transform[] childs = transform.GetComponentsInChildren<Transform>();

    foreach (Transform child in childs)
    {
      if (child.GetComponent<PlatformMovement>().playerTouch)
      {
        // Tu logica
      }
    }
  }

  // Update is called once per frame
  void Update()
  {
    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    if(Vector3.Distance(transform.position, target.position) < 0.1f)
    {
      Destroy(gameObject);
      Mathf.Clamp(transform.position.y, transform.position.y - 1, transform.position.y + 1);
    }
      
  }

  private void OnDrawGizmos()
  {
    Gizmos.color = Color.yellow;
    Gizmos.DrawLine(transform.position, target.position);
  }

  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("ColliderOut"))
    {
    }
  }
}
