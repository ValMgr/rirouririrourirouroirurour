using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Specialities {
  abstract public class Character {

    [Header ("Character")]
    [SerializeField] protected int hp = 100;
    [SerializeField] protected int armor = 0;
    [SerializeField] protected int damage = 10;
    protected bool isAlive = true;

    protected Character(int hp, int armor, int damage) {
      this.hp = hp;
      this.armor = armor;
      this.damage = damage;
      this.isAlive = true;
    }

    abstract public void useAbility(Character target);

    public void takeDamage(int damage) {
      hp -= damage;

      if (hp <= 0) {
        isAlive = false;
      }
    }

    public void getHealed(int heal) {
      hp += heal;
    }

    public int getHP() {
      return hp;
    }

    public int getArmor() {
      return armor;
    }

    public int getDamage() {
      return damage;
    }

    public bool isCharacterAlive() {
      return isAlive;
    }

  }
}