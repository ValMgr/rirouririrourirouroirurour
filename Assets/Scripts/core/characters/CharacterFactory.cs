using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Specialities {
  public enum CharacterType {
    Medic,
    Soldier,
    Engineer,
    Scientist
  }

  public class CharacterFactory {
    public static Character createCharacter(CharacterType type) {
      switch (type) {
        case CharacterType.Medic:
          return new Medic();
        case CharacterType.Soldier:
          return new Soldier();
        case CharacterType.Engineer:
          return new Engineer();
        case CharacterType.Scientist:
          return new Scientist();
        default:
          return null;
      }
    }

  }
}