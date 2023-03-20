using UnityEngine;

class Engineer : Character {

  public Engineer(int hp, int armor, int damage) : base(hp, armor, damage) {
    // Do something
    Debug.Log("Engineer created");
    Debug.Log("HP: " + hp);
    Debug.Log("Armor: " + armor);
    Debug.Log("Damage: " + damage);
  }

  public override void useAbility(Character target) {
    // Do something
  }

}
