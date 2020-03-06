namespace DDToolKit.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class Monsters : DbContext
    {
        public Monsters()
           //  :base("name=Monsters")
            //: base("name=DDToolContext_Azure")
            : base("name=Monsters")
            /*: base("name=ClassprojectContext_Azure")*/
        {
        }

        public virtual DbSet<Creature> Creatures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
