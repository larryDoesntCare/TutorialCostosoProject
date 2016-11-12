﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data.Configuration
{
   public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
       public StudentConfiguration()
       {
           ToTable("Student");
       }
    }
}
