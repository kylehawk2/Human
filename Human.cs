using System;

namespace Human
{
    class Human
    {
        public string name;
        public int str = 3;
        public int dex = 3;
        public int health = 100;
        public int intell = 3;
        public Human(string names){
            name = names;
        }
        public Human(string names, int strength, int dexerity, int intelligence, int healths){
            str = strength;
            name = names;
            intell = intelligence;
            health = healths;
        }
        public void Attack(object humans){
            Human enemy = humans as Human;
            if(enemy != null){
                enemy.health -= 5 * str;
            }
        }
    } 
}