using OpenGameContent_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGameContent_Class_Library.Ability_Scores
{
    public class AbilityScores
    {
        public Ability STR {get; set;}
        public Ability DEX {get; set;}
        public Ability INT {get; set;}
        public Ability CON {get; set;}
        public Ability WIS {get; set;}
        public Ability CHA {get; set;}

        public AbilityScores()
        {
            STR = new Ability() { BaseValue = 10 };
            DEX = new Ability() { BaseValue = 10 };
            INT = new Ability() { BaseValue = 10 };
            CON = new Ability() { BaseValue = 10 };
            WIS = new Ability() { BaseValue = 10 };
            CHA = new Ability() { BaseValue = 10 };
        }

    }
    public class Ability
    {
        public int BaseValue { get; set; }
        public int Score { get {return Calculate();} }        
        public int Modifier { get { return (Score - 10) / 2; } }
        public List<AbilityEffect> Effects { get; set; }
        private int Calculate()
        {
            int result = BaseValue;
            foreach(AbilityEffect effect in Effects)
            {
                //Add the value of the effect.
            }
            return result;
        }

        /// <summary>
        /// Sets the value of an Ability Score by rolling 4d6 and dropping the lowest roll.
        /// </summary>
        public void Generate()
        {
            Die die = new Die() { Sides = 6, Quantity = 4, DropLowest = 1 };
            BaseValue = die.Roll();
        }
    }

    public enum AbilityType
    {
        STR, DEX, INT, CON, WIS, CHA
    }

    public class AbilityEffect : Effect
    {
        public AbilityType Type { get; set; }
        public int Value { get; set; }
        public override  void Activate()
        {
            if (!Active)
            {
                Active = !Active;
            }
        }
        public override void Deactivate()
        {
            if (Active)
            {
                Active = !Active;
            }
        }
    }
}
