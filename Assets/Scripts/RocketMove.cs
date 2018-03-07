using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMove : MonoBehaviour
{
  public GameObject itself;
  public Rigidbody rock;

  public float RocketSpeed;
  public float MaxVelocity;

  // Limit Ship Velocity With MaxVelocity
  void LimitSpeed()
  {
    if (rock.velocity.magnitude > MaxVelocity)
      rock.velocity = rock.velocity.normalized * MaxVelocity;
  }

  void Update ()
  {
    rock.AddForce(RocketSpeed * transform.forward, ForceMode.Impulse);
	  LimitSpeed();
  }

  void OnTriggerEnter(Collider other)
  {
    Destroy(itself);
  }
}
