using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace FindYourTutorWebApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if(context.Database.GetPendingMigrations().Any())
            context.Database.Migrate();

            if (!context.Tutors.Any())
            {
                context.Tutors.AddRange(
                    new Tutor { 
                        Name = "Uebok",
                        LastName = "Zalupin",
                        MiddleName = "Petrovich",
                        BirthDate = new DateTime(1990, 6, 4) },
                    new Tutor { 
                        Name = "Pupa", 
                        LastName = "Lupin", 
                        BirthDate = new DateTime(1989, 7, 3) },
                    new Tutor { 
                        Name = "Vasyan",
                        LastName = "Erohin", 
                        MiddleName = "Vasyanovich",
                        BirthDate = new DateTime(1992, 9, 10) },
                    new Tutor {
                        Name = "Michail",
                        LastName = "Zubenko",
                        MiddleName = "Petrovich", 
                        BirthDate = new DateTime(1989, 11, 23) },
                    new Tutor
                    {
                        Name = "Vector",
                        LastName = "Tsoi",
                        BirthDate = new DateTime(1978, 2, 28)
                    },
                    new Tutor
                    {
                        Name = "Boba",
                        LastName = "Zigheilovich",
                        BirthDate = new DateTime(2000, 12, 2)
                    },
                    new Tutor
                    {
                        Name = "Vanya",
                        LastName = "Sidorov",
                        BirthDate = new DateTime(1993, 11, 4)
                    },
                    new Tutor
                    {
                        Name = "Joja",
                        LastName = "Finkelstein",
                        BirthDate = new DateTime(1978, 4, 5)
                    },
                    new Tutor
                    {
                        Name = "Tanya",
                        LastName = "Jopina",
                        BirthDate = new DateTime(1988, 5, 14)
                    },
                    new Tutor
                    {
                        Name = "Sanya",
                        LastName = "Sokolov",
                        BirthDate = new DateTime(1999, 12, 2)
                    },
                    new Tutor
                    {
                        Name = "Popa",
                        LastName = "Pipiskin",
                        BirthDate = new DateTime(2000, 11, 3)
                    },
                    new Tutor
                    {
                        Name = "Aslombek",
                        LastName = "Masturbaev",
                        BirthDate = new DateTime(2000, 12, 6)
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
