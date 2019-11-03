using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

  private bool inTrigger;
  private GameObject player;
  public CarManager CarMan;

void Update() {
  if(inTrigger == true){
    if(Input.GetKeyDown(Keycode.e)){
      CarMan.vehicleControl(player);
    }
  }
}

void OnTriggerEnter (Collider col) {
  inTrigger = true;
  player = col.GameObject;

  carMan.vehicleControl(player);
}

void OnTriggerExit () {
  inTrigger = false;
  player = null;
}
}
