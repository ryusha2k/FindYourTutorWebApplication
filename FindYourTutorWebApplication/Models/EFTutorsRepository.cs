using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models
{
    public class EFTutorsRepository : ITutorsRepository
    { 
        private ApplicationDbContext context;
        public EFTutorsRepository(ApplicationDbContext context) => this.context = context;
        public IQueryable<Tutor> Tutors => context.Tutors;
        public IQueryable<Subject> Subjects => context.Subjects;
    }
}
