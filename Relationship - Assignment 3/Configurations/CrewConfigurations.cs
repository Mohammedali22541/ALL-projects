//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Relationship___Assignment_3.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Relationship___Assignment_3.Configurations
//{
//    internal class CrewConfigurations : IEntityTypeConfiguration<Crew>
//    {
//        public void Configure(EntityTypeBuilder<Crew> builder)
//        {
//            builder.ToTable("Crews", tb =>
//            {
//                tb.HasCheckConstraint(
//                    "CK_Crews_AtLeastOneMember",
//                    "[MajorPilot] IS NOT NULL OR [AssistantPilot] IS NOT NULL OR [Host1] IS NOT NULL OR [Host2] IS NOT NULL"
//                );
//            });
//            builder.Property(x => x.MajorPilot).HasMaxLength(50);
//            builder.Property(x => x.AssistantPilot).HasMaxLength(50);
//            builder.Property(x => x.Host1).HasMaxLength(50);
//            builder.Property(x => x.Host2).HasMaxLength(50);
//        }
//    }
//}
