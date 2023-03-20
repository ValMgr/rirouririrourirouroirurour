using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic : Character {

  public Medic() {

  }

  public override void useAbility(Character target) {
    if(target.getHP() < 0) {
      return;
    }

    target.getHealed(20);
  }
  
}