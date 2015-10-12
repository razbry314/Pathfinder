using OpenGameContent_Class_Library.Creatures;
using OpenGameContent_Class_Library.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGameContent_Class_Library.Races
{
    public class Race
    {
        /// <summary>
        /// The name of the Race. (e.g. "Human" or "Dwarf".)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// If the race can select thier own Ability Score Bonus.
        /// </summary>
        public bool ChooseAbilityBonuses { get; set; }
        /// <summary>
        /// The ability scores that the Race gets a +2 racial bonus to.
        /// </summary>
        public List<Ability_Scores.AbilityType> AbilityScoreBonus { get; set; }
        /// <summary>
        /// The ability scores that the Race gets a -2 racial penalty to.
        /// </summary>
        public List<Ability_Scores.AbilityType> AbilityScoreMinus { get; set; }
        /// <summary>
        /// The size of the creature. Usually Medium for PC races.
        /// </summary>
        public CreatureSize Size { get; set; }
        /// <summary>
        /// The base speed of this race. Usually 30.
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Languages that all members of this race have access to.
        /// </summary>
        public List<Language> StartingLanguages { get; set; }
        /// <summary>
        /// The traits availible to that race. Regular Traits have a Replaces value of null.
        /// </summary>
        public List<RacialTrait> Traits { get; set; }
        /// <summary>
        /// Some racial traits add bonus points to skills. I'm thinking of just making these traits and removing this property.
        /// </summary>
        public List<SkillModifier> SkillBonuses { get; set; }
    }
}
