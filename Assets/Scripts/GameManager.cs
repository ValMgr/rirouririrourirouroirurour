using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
  
  public static GameManager instance;

  void Awake(){
    if(instance == null){
      instance = this;
    }
  }

  public GameManager getInstance(){
    return instance;
  }

  private void Start() {
    // Do something
  }
}