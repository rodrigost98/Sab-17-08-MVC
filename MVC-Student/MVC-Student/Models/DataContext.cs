using System.Data.Entity;

namespace MVC_Student.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Student.Models.Student> Students { get; set; }
    }
}