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
using System.IO;
using dreamstarter_web.Utilities;

namespace dreamstarter_web.Controllers
{
    public class ControlPanelController : Controller
    {
     

        public IActionResult PanelMain(){
            return View();
        }


        

       
      
    }
}

