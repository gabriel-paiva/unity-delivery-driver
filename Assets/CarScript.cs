using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
  [SerializeField] float steerSpeed = 300f;
  [SerializeField] float moveSpeed = 20f;
  [SerializeField] float slowSpeed = 10f;
  [SerializeField] float boostSpeed = 30f;

  // Update is called once per frame
  void Update()
  {
    float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
    float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, moveAmount, 0);
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Boost")
    {
      Debug.Log("You are boosting");
      moveSpeed = boostSpeed;
    }
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    moveSpeed = slowSpeed;
  }
}
