using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
  public Object rocket;
  public Transform shotpos;

	// Update is called once per frame
	void Update ()
  {
    // Shoot !
    if (Input.GetKeyDown(KeyCode.Space))
    {
      GameObject n_rocket = Instantiate(rocket, shotpos.position,
            shotpos.rotation) as GameObject;
      n_rocket.SetActive(true);
    }
	}
}
