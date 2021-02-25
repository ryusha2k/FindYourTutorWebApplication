using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindYourTutorWebApp.Models;
using FindYourTutorWebApp.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FindYourTutorWebApp.Controllers
{
    public class TutorsController : Controller
    {
        private ITutorsRepository repository;
        public TutorsController(ITutorsRepository repository) => this.repository = repository;
        public async Task<IActionResult> List(int page = 1)
        {
            int pageSize = 3;   // количество элементов на странице

            IQueryable<Tutor> source = repository.Tutors.Include(s => s.Subjects);
            var count = await source.CountAsync();  //  общее к-во элементов
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            TutorsListViewModel viewModel = new TutorsListViewModel
            {
                PageViewModel = pageViewModel,
                Tutors = items
            };
            return View(viewModel);
        }
        public IActionResult Tutor() => View();
    }
}