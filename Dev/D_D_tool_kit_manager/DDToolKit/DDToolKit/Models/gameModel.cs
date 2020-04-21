namespace DDToolKit.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class gameModel : DbContext
    {
        public gameModel()

           : base("name=Monsters")


           //: base("name=DDToolContext_Azure")


        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Save> Saves { get; set; }
        
        public virtual DbSet<Magic> Magics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<DDToolKit.Models.Map> Maps { get; set; }
    }
}
