using Pathfinder_RPG_Class_Library.Creatures;
using Pathfinder_RPG_Class_Library.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pathfinder_RPG_Class_Library.Races
{
    public class Race
    {
        /// <summary>
        /// The name of the Race. (e.g. "Human" or "Dwarf".)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// If the race is Human, Half-Elf, or Half-Orc, mark this as true.
        /// </summary>
        public bool ChooseAbilityBonuses { get; set; } //Humans, Half Elves, and Half Orcs get to choose thier bonuses.
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

    /// <summary>
    /// Class with final versions of Pathfinder Races.
    /// </summary>
    public sealed class Races
    {
        /// <summary>
        /// Returns an array of all the Pazio races.
        /// </summary>
        /// <returns></returns>
        public Race[] GetAllRaces()
        {
            List<Race> result = new List<Race>();
            result.AddRange(CoreRaces);
            result.AddRange(FeaturedRaces);
            result.AddRange(UncommonRaces);
            result.AddRange(OtherPazioRaces);
            return result.ToArray();
        }

        /// <summary>
        /// Core Races. Dwarf, Elf, Gnome, Half-Elf, Half-Orc, Halfling, and Human.
        /// </summary>
        #region CoreRaces
        public static Race[] CoreRaces = 
        {
            new Race()
            { 
                Name = "Human", 
                Size = CreatureSize.Medium, 
                ChooseAbilityBonuses = true,
                AbilityScoreBonus = {},
                AbilityScoreMinus = {},
                Speed = 30,
                StartingLanguages = { Language.Common },
                SkillBonuses = {},
                Traits = 
                {
                    //Regular Traits
                    new RacialTrait(){ Name = "Bonus Feat", Description = "Humans select one extra feat at 1st level."},
                    new RacialTrait(){ Name = "Skilled", Description = "Humans gain an additional skill rank at first level and one additional rank whenever they gain a level."},

                    //Alternate Traits
                    new RacialTrait(){ Name = "Adoptive Parentage", Description = "Humans are sometimes orphaned and adopted by other races. Choose one humanoid race without the human subtype. You start play with that race's languages and gain that race's weapon familiarity racial trait (if any). If the race does not have weapon familiarity, you gain either Skill Focus or Weapon Focus as a bonus feat that is appropriate for that race instead.", Replaces = "Bonus Feat"},
                    new RacialTrait(){ Name = "Dual Talent", Description = "", Replaces = ""}, //This thing replaces both AND the Human +2 to one ... How should I do that?
                    new RacialTrait(){ Name = "Eye for Talent", Description = "", Replaces = "Bonus Feat"},
                    new RacialTrait(){ Name = "Fey Magic", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Focused Study", Description = "", Replaces = "Bonus Feat"},
                    new RacialTrait(){ Name = "Heart of the Fields", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Mountains", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Sea", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Slums", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Snows", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Streets", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Sun", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heart of the Wilderness", Description = "", Replaces = "Skilled"},
                    new RacialTrait(){ Name = "Heroic", Description = "", Replaces = "Bonus Feat"},
                    new RacialTrait(){ Name = "Mixed Heritage", Description = "", Replaces = "Bonus Feat"},
                    new RacialTrait(){ Name = "Silver Tongued", Description = "", Replaces = "Skilled"}
                }
            },
            new Race()
            { 
                Name = "Dwarf", 
                Size = CreatureSize.Medium, 
                ChooseAbilityBonuses = false,
                AbilityScoreBonus = {},
                AbilityScoreMinus = {},
                Speed = 20,
                StartingLanguages = { Language.Common, Language.Dwarven },
                SkillBonuses = 
                { 
                    new SkillModifier(){ Type = SkillType.Appraise, Value = 2, Name="Dwarven Greed", Description="Dwarves gain a +2 racial bonus on Appraise checks made to determine the price of non-magical goods that contain precious metals or gemstones."},
                    new SkillModifier(){ Type = SkillType.Perception, Value = 2, Name="Dwarven Stonecutting", Description="Dwarves gain a +2 bonus on Perception checks to notice unusual stonework, such as traps and hidden doors located in stone walls or floors. They receive a check to notice such features whenever they pass within 10 feet of them, whether or not they are actively looking."}
                },
                Traits = 
                {
                    //Regular Traits
                    new RacialTrait(){ Name = "", Description = "", Replaces = ""},
                    
                    //Alternate Traits                    
                    new RacialTrait(){ Name = "", Description = "", Replaces = ""}
                }
            }
        };
        #endregion

        /// <summary>
        /// Aasimar, Catfolk, Dhampir, Drow, Fetchling, Goblin, Hobgoblin, Ifrit, Kobold, Orc, Oread, Ratfolk, Sylph, Tengu, Tiefling, Undine
        /// </summary>
        #region
        public static Race[] FeaturedRaces = 
        {

        };
        #endregion

        /// <summary>
        /// Changeling, Duergar, Gillman, Grippli, Kitsune, Merfolk, Nagaji, Samsaran, Strix, Suli, Svirfneblin, Vanara, Vishkanya, Wayang
        /// </summary>
        #region
        public static Race[] UncommonRaces = 
        {

        };
        #endregion

        /// <summary>
        /// Android, Ghoran, Monkey Goblin, Lashunta, Wyvaran
        /// </summary>
        #region
        public static Race[] OtherPazioRaces = 
        {

        };
        #endregion

    }
}
