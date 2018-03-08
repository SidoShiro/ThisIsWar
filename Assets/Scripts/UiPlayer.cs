using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiPlayer : MonoBehaviour
{
  public Move PlayerShipEngine;
  public float speed;
  public Text SpeedText;

  void SetSpeedText ()
  {
    speed = PlayerShipEngine.GetSpeed();
    int x = (int)speed;
    SpeedText.text = "Speed: " + x.ToString();
  }

	void LateUpdate ()
  {
    SetSpeedText();
	}
}
