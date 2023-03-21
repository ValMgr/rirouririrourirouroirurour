using UnityEngine;
using Player;
using Specialities;

namespace Scenes {
  public class Init : MonoBehaviour {
    
    private GameObject usernamePrompt;
    private GameObject characterPrompt;
    private string _usernameState;

    private void Start() {
      usernamePrompt = GameObject.Find("UsernamePrompt");
      characterPrompt = GameObject.Find("CharacterPrompt");

      usernamePrompt.SetActive(true);
      characterPrompt.SetActive(false);
    }

    public void setUsernameState(string value) {
      _usernameState = value;
    }

    public void OnUsernameSubmit() {
      if (_usernameState == null || _usernameState == "") {
        throw new System.Exception("Username cannot be empty");
      }

      GameObject.Find("Player").GetComponent<PlayerController>().setUsername(_usernameState);
      usernamePrompt.SetActive(false);
      characterPrompt.SetActive(true);
    }

    public void onCharacterSubmit(string value) {
      if (!CharacterType.IsDefined(typeof(CharacterType), value)){
        throw new System.Exception("Invalid character type");
      }

      CharacterType type = (CharacterType) System.Enum.Parse(typeof(CharacterType), value);
      GameObject.Find("Player").GetComponent<PlayerController>().setSpeciality(type);
    }

  }
}