using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AarcharSweets.Models;
using AarcharSweets.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AarcharSweets.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            var piesListVm = new PiesListViewModel
            {
                Pies = _pieRepository.Pies,
                CurrentCategory = "Cheese Cakes"
            };
            return View(piesListVm);
        }
    }
}