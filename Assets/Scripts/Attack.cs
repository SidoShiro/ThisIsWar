using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
  public Object rocket;

	// Update is called once per frame
	void Update ()
  {
    // Shoot !
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Vector3 minus = new Vector3(0, 1, 0);
      Vector3 pos = transform.position;
      pos -= minus;
      Instantiate(rocket, pos, transform.rotation);
    }
	}
}
