using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  [SerializeField] private Character _character;

  private void Start() {
    _character = new Engineer(100, 0, 10);
  }
}