namespace DDToolKit.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string OwnerID { get; set; }

        public int? GameID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Size { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(20)]
        public string Aligment { get; set; }

        public int? ArmorClass { get; set; }

        public int? HitPoints { get; set; }

        public int? Strength { get; set; }

        public int? Dexterity { get; set; }

        public int? Constitution { get; set; }

        public int? Intelligence { get; set; }

        public int? Wisdom { get; set; }

        public int? Charisma { get; set; }

        [StringLength(500)]
        public string Languages { get; set; }

        [StringLength(500)]
        public string Speed { get; set; }

        [StringLength(500)]
        public string Proficiencies { get; set; }

        [StringLength(500)]
        public string DamageResistance { get; set; }

        [StringLength(500)]
        public string ConditionImmunity { get; set; }

        [StringLength(500)]
        public string Senses { get; set; }

        [StringLength(500)]
        public string SpecialAbility { get; set; }

        public string Actions { get; set; }
    }
}
