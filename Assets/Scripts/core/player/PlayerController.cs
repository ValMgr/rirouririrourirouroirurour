using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Specialities;

namespace Player {
  public class PlayerController : MonoBehaviour {

    public Character _speciality;
    public string username;

    private void Awake() {
      DontDestroyOnLoad(gameObject);
    }

    private void Start() {

    }

    public void setUsername(string username) {
      this.username = username;
    }

    public void setSpeciality(CharacterType speciality) {
      this._speciality = CharacterFactory.createCharacter(speciality);
    }
  }

}