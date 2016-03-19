using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getStats.Models {
    class Unit {
        // General
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Culture { get; set; }
        public int Level { get; set; }
        public int WagesMax { get; set; }
        public int WagesMin { get; set; }

        // Attributes
        public int Str { get; set; }
        public int Agi { get; set; }
        public int Health { get; set; }

        // Skills
        public int Ironflesh { get; set; }
        public int PowerStrike { get; set; }
        public int PowerThrow { get; set; }
        public int PowerDraw { get; set; }
        public int Atheltics { get; set; }
        public int Riding { get; set; }
        public int HorseArchery { get; set; }

        // Proficiencies
        public int OneHandedProf { get; set; }
        public int TwoHandedProf { get; set; }
        public int PolearmProf { get; set; }
        public int ArcheryProf { get; set; }
        public int CrossbowProf { get; set; }
        public int ThrowingProf { get; set; }

        // Items
        public Item WeaponOne { get; set; }
        public Item WeaponTwo { get; set; }
        public Item WeaponThree { get; set; }
        public Item WeaponFour { get; set; }
        public Horse Horse { get; set; }
        public Item ArmorHelm { get; set; }
        public Item ArmorTorso { get; set; }
        public Item ArmorBoots { get; set; }
        public Item ArmorGloves { get; set; }


    }
}
