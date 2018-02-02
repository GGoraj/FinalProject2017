using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dreamstarter_web.Models.ViewModels;
using dreamstarter_web.Models.Entities;
using dreamstarter_web.Models.Repositories;
using dreamstarter_web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using dreamstarter_web.Utilities;
using Microsoft.Extensions.FileProviders;
using System.Collections;

namespace dreamstarter_web.Controllers
{
    //[Authorize]
    public class CampaignController : Controller
    {
        private ICampaignRepository _campaignRepository;

        private readonly IFileProvider _fileProvider;
        private ILikeCampaignRepository _likeCampaignRepository;

        //Constructor
        public CampaignController(ICampaignRepository campaignRepository,
                                 IFileProvider fileProvider,
                                 ILikeCampaignRepository likeCampaignRepository)
        {
            _campaignRepository = campaignRepository;
            _fileProvider = fileProvider;
            _likeCampaignRepository = likeCampaignRepository;
        }

        [HttpGet]
        public IActionResult NewCampaign()
        {
            return View();
        }


        //crate new campaign
        [HttpPost]
        public async Task<IActionResult> NewCampaign(NewCampaignViewModel model)
        {
            // if (!ModelState.IsValid)
            // {
            //     return Content("something wrong with model");
            // }
            if(ModelState.IsValid){
                if (model.PhotoFile.Length == 0)
                return Content("file not selected");

            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot",
                        model.PhotoFile.GetFilename());

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.PhotoFile.CopyToAsync(stream);
            }

        
            Campaign campaign = new Campaign();
            campaign.UserId = AccountController.UserId; // temporary solution
            campaign.Title = model.Title;
            campaign.ThemeImageFileName = model.PhotoFile.GetFilename();
            campaign.Synopsis = model.Synopsis;
            campaign.DetailDescription = model.DetailDescription;
            campaign.AmountRequired = model.AmountRequired;
            campaign.AmountRaised = 0;
            campaign.StartDate = DateTime.Now;
            campaign.EndDate = model.EndDate;

            _campaignRepository.Save(campaign);
            return RedirectToAction("Index", "Home");

            }
            return View();
            
        }

        [HttpGet]
        public IActionResult DetailCampaign(int Id)
        {

            Console.WriteLine("******************************* ID received: " + Id + "**************************************");
            //accessing particular - pointed - campaign from repository
            Campaign campaign = _campaignRepository.GetCampaignById(Id);

            int percentageDone = (int)Math.Floor((campaign.AmountRaised / campaign.AmountRequired) * 100);
            TimeSpan timeLeft = (campaign.EndDate - campaign.StartDate);
            //DateTime substracted gives TimeSpan object - one of it's properties are Days
            int daysLeft = timeLeft.Days;

            int likesNumber = _likeCampaignRepository.NumberOfLikes(Id);



            DetailCampaignViewModel dcvm = new DetailCampaignViewModel()
            {
                CampaignId = Id,
                Title = campaign.Title,
                Synopsis = campaign.Synopsis,
                ThemeImageFileName = campaign.ThemeImageFileName,
                AmountRequired = campaign.AmountRequired,
                DaysLeft = daysLeft,
                PercentDone = percentageDone,
                DetailDescription = campaign.DetailDescription,
                AmountRaised = campaign.AmountRaised,
                NumberOfLikes = likesNumber,
                UserId = AccountController.UserId
            };
            return View(dcvm);
        }


        //used to like campaign (DetailCampaign view)
        [Route("/api/like")]
        [HttpPost]
        public IActionResult LikeCampaign(LikeCampaignApiModel model)
        {
            //source: http://www.binaryintellect.net/articles/c69d78a3-21d7-416b-9d10-6b812a862778.aspx

            //'like' was pressed - like or unlike campaign - depending on state of the record
            Console.WriteLine(" Model from Json: " + model.CampaignId + "  " + AccountController.UserId);
            _likeCampaignRepository.LikeCampaign(AccountController.UserId, model.CampaignId);
            int numberOfLikes = _likeCampaignRepository.NumberOfLikes(model.CampaignId);
            return Json(numberOfLikes);
        }

        [Route("/api/fund")]
        [HttpPost]
        public IActionResult FundCampaign(FundModel fundmodel){
           
           double fund_update;

            if(!ModelState.IsValid){
                fund_update = -1;
                return Json(fund_update);
            }
            else{
               Console.WriteLine("Money comes: ************* " + fundmodel.CampaignId + " **** " + fundmodel.Amount);
               _campaignRepository.MakeDonation(fundmodel.CampaignId, fundmodel.Amount);
                fund_update = fundmodel.Amount;
                return Json(fund_update);
            }
        }

    }
}

