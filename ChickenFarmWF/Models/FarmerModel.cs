using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ChickenFarmWF.Models
{
    public class FarmContext : DbContext
    {
        public DbSet<Farmer> Farmers { get; set; }
    }

    public class Farmer
    {
        [Key, Display(Name = "ID")]
        [ScaffoldColumn(false)]
        public int FarmerId { get; set; }

        [Required, StringLength(40), Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(20), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [EnumDataType(typeof(License)), Display(Name = "Licesnse")]
        public License Year { get; set; }

        //public virtual ICollection<Chicken> Chickens { get; set; }
    }

    public enum License
    {
        Residential,
        Commercial,
        International
    }
}