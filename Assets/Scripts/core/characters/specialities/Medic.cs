using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic : Character {

  public Medic(int hp, int armor, int damage) : base(hp, armor, damage) {
    // Do something
  }

  public override void useAbility(Character target) {
    if(!target.isCharacterAlive()) {
      return;
    }

    target.getHealed(20);
  }
  
}