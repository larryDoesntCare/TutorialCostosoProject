﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data.Configuration
{
   public class OfficeAssignmentConfiguration:EntityTypeConfiguration<OfficeAssignment>
    {
       public OfficeAssignmentConfiguration()
       {
           ToTable("OfficeAssignment");
           Property(of => of.Location).IsRequired().HasMaxLength(50);

       }
    }
}
