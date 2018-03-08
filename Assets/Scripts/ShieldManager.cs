using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldManager : MonoBehaviour {

  public bool Triggering = true;
  public bool Show = true;

  public MeshRenderer ShieldShow;
  
  // TODO
  // COllider to set on off
  // Handle Shield Points Effects

  void Start()
  {
    // Start Shields Off
    SetShield();
  }

  void SetShield()
  {
    if (false == Show)
    {
      Show = true;
      Triggering = true;
      ShieldShow.enabled = true;
    }
    else
    {
      Show = false;
      Triggering = false;
      ShieldShow.enabled = false;
    }
  }

	// Update is called once per frame
	void Update ()
  {
		if (Input.GetKeyDown(KeyCode.T))
      SetShield();
	}
}
