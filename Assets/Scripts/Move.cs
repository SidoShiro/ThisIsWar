using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  public Rigidbody lol;
	public float MaxVelocity  = 7f;
  public float ForceFront   = 0.75f;
  public float ForceBack    = 0.5f;
  public float ForceLat     = 6f;
  public int TurnSpeed      = 70;
  public float TimeLatMax     = 0.2f;

  private float TimeLateral   = 0.2f;
  private bool hasLat       = false;


  public float GetSpeed()
  {
    return lol.velocity.magnitude;
  }

  // Limit Ship Velocity With MaxVelocity
  void LimitSpeed()
  {
    if (lol.velocity.magnitude > MaxVelocity)
      lol.velocity = lol.velocity.normalized * MaxVelocity;
  }

  // Update is called once per frame
	void Update ()
  {
    //if (Input.GetKeyDown(KeyCode.Space))
    //{
    //  lol.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
    //}

    if (hasLat)
    {
      if (TimeLateral <= 0)
      {
        hasLat = false;
        lol.velocity = lol.velocity.normalized * 0f;
        TimeLateral = TimeLatMax;
      }
      else
      {
        TimeLateral -= Time.deltaTime;
      }
    }
    else
    {
      if (lol.velocity.magnitude > 0.5f)
      {
        lol.velocity = lol.velocity * 0.99f;
      }
      /* Front / Back */
      if (Input.GetKey(KeyCode.Z))
      {
        lol.AddForce(ForceFront * transform.forward, ForceMode.Impulse);
        LimitSpeed();
      }
      else if (Input.GetKey(KeyCode.S))
      {
        lol.AddForce(ForceBack * -transform.forward, ForceMode.Impulse);
        LimitSpeed();
      }

      /* Turn */
      if (Input.GetKey(KeyCode.Q))
      {
        transform.Rotate(0, (-Time.deltaTime * TurnSpeed), 0);
      }
      else if (Input.GetKey(KeyCode.D))
      {
        transform.Rotate(0, (Time.deltaTime * TurnSpeed), 0);
      }

      /* Lateral Move Thrusters */
      if (!hasLat && Input.GetKeyDown(KeyCode.A))
      {
        lol.AddForce(ForceLat * -transform.right, ForceMode.Impulse);
        hasLat = true;
      }
      else if (!hasLat && Input.GetKeyDown(KeyCode.E))
      {
        lol.AddForce(ForceLat * transform.right, ForceMode.Impulse);
        hasLat = true;
      }

      /* Stop */
      if (Input.GetKeyDown(KeyCode.X))
      {
        lol.velocity = lol.velocity.normalized * 0f;
      }
    }
  }
}
