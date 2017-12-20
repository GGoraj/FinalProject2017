using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dreamstarter_web.Models.ViewModels;
using dreamstarter_web.Models;
using Microsoft.AspNetCore.Http;
using dreamstarter_web.Models.Repositories;
using dreamstarter_web.Models.Entities;

namespace dreamstarter_web.Controllers
{

    public class HomeController : Controller
    {

        private readonly ICampaignRepository _campaignRepository;

        public HomeController(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Campaign> allCampaigns = _campaignRepository.GetAllCampaigns();
            return View(allCampaigns);
        }

    }
}