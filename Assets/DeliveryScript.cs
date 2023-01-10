using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryScript : MonoBehaviour
{
  bool hasPackage = false;
  private void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Ouch!");
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      hasPackage = true;
      Debug.Log("Package picked up!");
      Destroy(other.gameObject, 0.5f);
    }

    if (other.tag == "Customer" && hasPackage)
    {
      hasPackage = false;
      Debug.Log("Package delivered!");
    }
  }
}
