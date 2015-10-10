using Pathfinder_RPG_Class_Library.Ability_Scores;
using Pathfinder_RPG_Class_Library.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Skills
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
        Skill Acrobatics { get; set; }
        Skill Appraise { get; set; }
        Skill Bluff { get; set; }
        Skill Climb { get; set; }
        Skill Craft { get; set; }
        Skill Diplomacy { get; set; }
        Skill Disguise { get; set; }
        Skill Escape_Artist { get; set; }
        Skill Fly { get; set; }
        Skill Handle_Animal { get; set; }
        Skill Heal { get; set; }
        Skill Intimidate { get; set; }
        Skill Knowledge_Arcana { get; set; }
        Skill Knowledge_Dungeoneering { get; set; }
        Skill Knowledge_Engineering { get; set; }
        Skill Knowledge_Geography { get; set; }
        Skill Knowledge_History { get; set; }
        Skill Knowledge_Local { get; set; }
        Skill Knowledge_Nature { get; set; }
        Skill Knowledge_Nobility { get; set; }
        Skill Knowledge_Planes { get; set; }
        Skill Knowledge_Religion { get; set; }
        Skill Linguistics { get; set; }
        Skill Perception { get; set; }
        Skill Perform { get; set; }
        Skill Ride { get; set; }
        Skill Sense_Motive { get; set; }
        Skill Sleight_of_Hand { get; set; }
        Skill Spellcraft { get; set; }
        Skill Stealth { get; set; }
        Skill Survival { get; set; }
        Skill Swim { get; set; }
        Skill Use_Magic_Device { get; set; }

        public SkillSet()
        {
            //TODO: Finish filling these out for a default skillset.
            Acrobatics = new Skill() { Ability = AbilityType.DEX, Trained = false, IsClassSkill = false };
        }
    }


    public enum SkillType
    {
        Acrobatics,
        Appraise,
        Bluff,
        Climb,
        Craft,
        Diplomacy,
        Disable_Device,
        Disguise,
        Escape_Artist,
        Fly,
        Handle_Animal,
        Heal,
        Intimidate,
        Knowledge_Arcana,
        Knowledge_Dungeoneering,
        Knowledge_Geography,
        Knowledge_History,
        Knowledge_Local,
        Knowledge_Nature,
        Knowledge_Nobility,
        Knowledge_Planes,
        Knowledge_Religion,
        Linguistics,
        Perception,
        Perform,
        Profession,
        Ride,
        Sense_Motive,
        Sleight_of_Hand,
        Spellcraft,
        Stealth,
        Survival,
        Swim,
        Use_Magical_Device
    }
}
