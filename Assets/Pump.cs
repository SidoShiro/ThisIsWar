using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pump : MonoBehaviour
{
  public Rigidbody lol;
	// Update is called once per frame
	void Update ()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      lol.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
    }
    if (Input.GetKey(KeyCode.Z))
    {
      // lol.velocity = Vector3.ClampMagnitude(lol.velocity.magnitude, 5f);
      // transform.position += transform.forward * Time.deltaTime * 10;
      lol.AddForce(0.75f * transform.forward, ForceMode.Impulse);
      // lol.AddRelativeForce(new Vector3(0,0,5), ForceMode.Impulse);
      if ( lol.velocity.magnitude > 7f)
        lol.velocity = lol.velocity.normalized * 7f;
    }
    if (Input.GetKey(KeyCode.Q))
    {
      transform.Rotate(0, -Time.deltaTime * 100, 0);
    }
    if (Input.GetKey(KeyCode.S))
    {
      lol.AddForce(0.75f * -transform.forward, ForceMode.Impulse);
      if ( lol.velocity.magnitude > 7f)
        lol.velocity = lol.velocity.normalized * 7f;
    }
    if (Input.GetKey(KeyCode.D))
    {
      transform.Rotate(0, Time.deltaTime * 100, 0);
    }
  }
}
