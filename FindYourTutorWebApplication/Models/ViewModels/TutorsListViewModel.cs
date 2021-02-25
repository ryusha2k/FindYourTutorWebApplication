﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourTutorWebApp.Models.ViewModels
{
    public class TutorsListViewModel
    {
        public IEnumerable<Tutor> Tutors { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }

}
