using OpenGameContent_Class_Library.Ability_Scores;
using OpenGameContent_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGameContent_Class_Library.Skills
{
    /// <summary>
    /// Represents a Skill.
    /// </summary>
    public class Skill
    {
        public AbilityType Ability { get; set; }
        public bool IsClassSkill { get; set; }
        public bool Trained { get; set; }
        public int Ranks { get; set; }
        public int AbilityPoints { get; set; }
        public int Score { get {return Calculate();}}
        public List<SkillModifier> Modifiers { get; set; }
        private int Calculate()
        {
 	        int result = 0;
            result += AbilityPoints;
            if(Ranks > 0){
                result += Ranks;
                result += Trained ? 3 : 0;
            }
            foreach (SkillModifier modifier in Modifiers)
            {
                result += modifier.Value;
            }
            return result;
        }

        public int RollCheck()
        {
            Die skillCheckDie = new Die() { Quantity = 1, Sides = 20, Modifier = Score };
            return skillCheckDie.Roll();
        }

        /// <summary>
        /// Rolls a Skill Check and Takes 10 as the result of the roll. The Character doing this must not be in immediate danger or distracted.
        /// </summary>
        /// <returns></returns>
        public int RollCheckTakeTen()
        {
            return 10 + Score;
        }
        public int RollCheckTakeTwenty()
        {
            return 20 + Score;
        }

    }

    /// <summary>
    /// Represents an Effect that modifies the level of a Skill.
    /// </summary>
    public class SkillModifier : Effect
    {
        public SkillType Type {get; set;}
        public int Value {get; set;}

        
        public override void Activate()
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

    public class SkillSet
    {

    }


    public enum SkillType
    {

    }
}
