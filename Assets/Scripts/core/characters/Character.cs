using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Character : MonoBehaviour {

  [Header ("Character")]
  [SerializeField] protected int hp = 100;
  [SerializeField] protected int armor = 0;
  [SerializeField] protected int damage = 10;

  abstract public void useAbility(Character target);

  public void takeDamage(int damage) {
    hp -= damage;
  }

  public void getHealed(int heal) {
    hp += heal;
  }

  public int getHP() {
    return hp;
  }

}