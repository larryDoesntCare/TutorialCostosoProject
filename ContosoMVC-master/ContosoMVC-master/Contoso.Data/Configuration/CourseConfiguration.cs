using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data.Configuration
{
  public  class CourseConfiguration : EntityTypeConfiguration<Course>
    {
      public CourseConfiguration()
      {
          ToTable("Course");
          Property(c => c.Title).IsRequired().HasMaxLength(50);
          Property(c => c.Credits).IsRequired();
      }
    }
}
