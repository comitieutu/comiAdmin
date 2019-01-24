using ComiCore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComiCore
{
    public static class ComiSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonInfo>().Ignore(p => p.FullName);
        }
    }
}
