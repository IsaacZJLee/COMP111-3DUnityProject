using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarManager : MonoBehaviour {

public Camera CarCam;
public CarUserControl userCtrl;

private bool inCar;
private GameObject player;

void Start(){
  userCtrl.enabled = false;
  CarCam.enabled = false;
  inCar = false;
}

void Update() {
  if(Input.GetKeyDown(Keycode.e)){
    if(inCar == true){
      vehicleControl(null);
    }
  }
}

public void vehicleControl(GameObject playerObj){
  if(inCar == false){
    player = playerObj;
    CarCam.enabled = true;
    userCtrl.enabled = true;
    player.SetActive(false);
    player.transform.parent = this.transform;

    inCar = true;
  }

  else{
    player = null;
    CarCam.enabled = false;
    userCtrl.enabled = false;
    player.SetActive(true);
    player.transform.parent = null;

    inCar = false;
  }
}
}
