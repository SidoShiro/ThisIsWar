using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnArr : MonoBehaviour {

  public GameObject parent;
  public GameObject tr;

	void Update ()
  {
    tr.transform.Rotate(1, 1, 1);
    tr.transform.LookAt(parent.transform);
    tr.transform.position += tr.transform.right * Time.deltaTime;
	}
}
