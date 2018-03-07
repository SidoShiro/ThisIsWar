using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

  public GameObject to_follow;
  public float yAx = 30;

  private Vector3 to_move;

  void Start()
  {
    to_move.y = yAx;
  }

	// Update is called once per frame
	void Update ()
  {
    to_move.x = to_follow.transform.position.x;
    to_move.z = to_follow.transform.position.z;
    transform.position = to_move;
	}
}
