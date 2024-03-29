﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class CategoryConfiguration:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);//İd olacak
            builder.Property(x => x.Id).UseIdentityColumn();//1-1 artan
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);//zorunlu olsun ve max karekter özelliği
            builder.ToTable("Categories");//Tablo ismi
        }
    }
}
