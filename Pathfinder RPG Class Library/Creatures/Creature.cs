using Pathfinder_RPG_Class_Library.Ability_Scores;
using Pathfinder_RPG_Class_Library.Items;
using Pathfinder_RPG_Class_Library.Lore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder_RPG_Class_Library.Creatures
{
    class Creature
    {
        public CreatureLore Lore { get; set; }
        public AbilityScores AbilityScores { get; set; }

        public Inventory Inventory { get; set; }
        public long CR { get; set; }
        public int Initiative { get; set; }
        public int Armor_Class { get; set; }
        public int Touch_Armor_Class { get; set; }
        public int Flat_Footed_Armor_Class { get; set; }
        public int Speed { get; set; }

        enum CreatureType
        {
            Aberration,
            Animal,
            Construct,
            Dragon,
            Fey,
            Humanoid,
            Magical_Beast,
            Monstrous_Humanoid,
            Ooze,
            Outsider,
            Plant,
            Undead,
            Vermin
        }

        enum CreatureSubType
        {
            Adlet,
            Aeon,
            Agathion,
            Air,
            Angel,
            Aquatic,
            Archon,
            Asura,
            Augmented,
            Azata,
            Behemoth,
            Catfolk,
            Chaotic,
            Clockwork,
            Cold,
            Colossus,
            Daemon,
            Dark_Folk,
            Demodand,
            Demon,
            Devil,
            Div,
            Dwarf,
            Earth,
            Elemental,
            Elf,
            Evil,
            Extraplanar,
            Fire,
            Giant,
            Gnome,
            Goblinoid,
            Godspawn,
            Good,
            Great_Old_One,
            Halfling,
            Herald,
            Human,
            Incorporeal,
            Inevitable,
            Kaiju,
            Kami,
            Kasatha,
            Kitsune,
            Kyton,
            Lawful,
            Leshy,
            Mythic,
            Native,
            Nightshade,
            Oni,
            Orc,
            Protean,
            Psychopomp,
            Qlippoth,
            Rakshasa,
            Ratfolk,
            Reptilian,
            Robot,
            Samsaran,
            Sasquatch,
            Shapechanger,
            Swarm,
            Troop,
            Udaeus,
            Unbreathing,
            Vanara,
            Vishkanya,
            Water,
            Wayang
        }
    }
}
