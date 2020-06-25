using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCodeFirst
{
    public class SchoolEntities : DbContext
    {
        public SchoolEntities() : base("name=SchoolConnection")
        {
            Database.SetInitializer<SchoolEntities>(new CreateDatabaseIfNotExists<SchoolEntities>());
            //Database.SetInitializer<SchoolEntities>(new DropCreateDatabaseIfModelChanges<SchoolEntities>());
            //Database.SetInitializer<SchoolEntities>(new DropCreateDatabaseAlways<SchoolEntities>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
