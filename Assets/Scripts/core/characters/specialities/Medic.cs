using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Specialities {
  public class Medic : Character {

    public Medic() : base(80, 10, 10) {
      // Do something
    }

    public override void useAbility(Character target) {
      if(!target.isCharacterAlive()) {
        return;
      }

      target.getHealed(20);
    }
    
  }
}