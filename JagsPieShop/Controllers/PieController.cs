using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JagsPieShop.Models;
using JagsPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace JagsPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository pieRepository;
        private readonly ICategoryRepository categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            // ViewBag.CurrentCategory = "Yappal pee";
            // return View(pieRepository.AllPies);

            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = pieRepository.AllPies;
            piesListViewModel.CurrentCategory = "Cheese Cakes!";

            return View(piesListViewModel);
        }

    }
}
