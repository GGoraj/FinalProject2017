using System;
using System.Linq;
using dreamstarter_web.Models;
using Microsoft.Extensions.DependencyInjection;
using dreamstarter_web.Models.Entities;

// 1. remove unnessary usings

// 2. our application is called ConsoleApplication and we do not have a data folder, 
//i put it in Models instead

namespace dreamstarter_web.Models
{
    public static class DbInitializer
    {
        public static void Initialize(MyDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any()) // if there is any users true / false
            {
                return;   // DB has been seeded
            }
            else
            {
                var users = new User[]{

                    //#1
                    new User{Name="Anabel", Surname="aaa", Town = "aaa", Postcode= "aaa",
                            Street = "aaa", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "a@gmail.com", Password= "a", ProfilePicture="cute-panda.png"},
                    //#2
                    new User{Name="Beatrice", Surname="Doe", Town = "Some", Postcode= "2300",
                            Street = "Some Street", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "b@gmail.com", Password= "b", ProfilePicture="beatrice.jpg"},
                    //#3
                    new User{Name="Claudia", Surname="Doe", Town = "Some", Postcode= "2300",
                            Street = "Some Street", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "c@gmail.com", Password= "c"},
                    //#4
                    new User{Name="Dorothy", Surname="Doe", Town = "Some", Postcode= "2300",
                            Street = "Some Street", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "d@gmail.com", Password= "d"},
                    //#5
                    new User{Name="Eugenia", Surname="Doe", Town = "Some", Postcode= "2300",
                            Street = "Some Street", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "e@gmail.com", Password= "e"},
//#1
                    //#6
                    new User{Name="Faisal", Surname="Doe", Town = "Some", Postcode= "2300",
                            Street = "Some Street", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "f@gmail.com", Password= "f", ProfilePicture="faisal.jpg"},
                    //#7
                    new User{Name="Gregory", Surname="Doe", Town = "Some", Postcode= "2300",
                            Street = "Some Street", StreetNr = "23 tv", Mobile = "60134479",
                            Email= "g@gmail.com", Password= "g", ProfilePicture="friendly+face.jpg"},
                    
                    

                };
                foreach (User user in users)
                {
                    context.Users.Add(user);
                }
                context.SaveChanges();
            
            if(context.Campaigns.Any()){
                return;
            }
            else {
                
                var campaigns = new Campaign[]{

                    new Campaign{ Title="Help me go to Moon next month",
                                Synopsis=           "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut",
                                
                                ThemeImageFileName= "moontrip.jpg",
                                AmountRequired= 11297,
                                AmountRaised= 340,
                                
                                DetailDescription=  "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 1 },

                    new Campaign{Title="I want to Kite!",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            "quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",

                                ThemeImageFileName= "kiting.jpg",
                                AmountRequired= 15000,
                                AmountRaised= 5698,
                                
                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 2 },

                    new Campaign{Title="I'd like to move to Loth Lorien",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "lothlorien.jpg",
                                
                                AmountRequired= 5433,
                                AmountRaised= 1365,
                                
                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 3 },
                    

                    new Campaign{Title="Help me meet Jim Carrey",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",

                                ThemeImageFileName= "jimcarey.jpg",

                                AmountRequired= 3000,
                                AmountRaised= 340,
                                
                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 3 },

                    new Campaign{Title="I'd like to learn parachute jumping",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "pjumping.jpg",
                                AmountRequired= 1020,
                                AmountRaised= 345,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 4 },

                
                new Campaign{Title="Ud - Lessons",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "ud.png",
                                AmountRequired= 6000,
                                AmountRaised= 1256,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 5 },

                

                new Campaign{Title="Send me to Japan so we Win together",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "teakwondo.jpg",
                                AmountRequired= 9856,
                                AmountRaised= 1476,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 6 },

                new Campaign{Title="1 more to my 9999 Tamagotchi collection",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                AmountRequired= 657,
                                AmountRaised= 365,

                                ThemeImageFileName= "tamagotchi.jpg",

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 7 },



                

                new Campaign{Title="I have a lifetime oportunity to meet Dalaylama - Paris",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "dalaylama.jpg",
                                AmountRequired= 4000,
                                AmountRaised= 1345,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 7 },

                
                new Campaign{Title="Nikon Slr - I need a new one - it's urgent, please help",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "slr.jpeg",
                                AmountRequired= 8000,
                                AmountRaised= 6345,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 7 },

                

                new Campaign{Title="Swimming is healing!",
                                Synopsis=   "keeps your heart rate up but takes some of the impact stress off your"+
                                            "builds endurance, muscle strength and cardiovascular fitness. helps maintain a healthy"+
                                            "weight, healthy heart and lungs. tones muscles and builds strength.",
                                
                                ThemeImageFileName= "swimming.jpg",
                                AmountRequired= 2000,
                                AmountRaised= 0,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 6 },

                

                new Campaign{Title="I'm dreaming of going to New York this January",
                                Synopsis=  "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                            " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                            "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                            "laboris nisi ut aliquip ex ea commodo consequat. Duis aute",
                                
                                ThemeImageFileName= "newyork.png",
                                AmountRequired= 10000,
                                AmountRaised= 0,

                                DetailDescription= "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+
                                                    "Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi"+"Lorlabore et dolore magna aliqua. Ut enim ad minim venia"+
                                                    " quiso eiusmod tempor incididunt ut labore et dolore magna aliqua"+
                                                    "Ut enim ad minim veniam, quis nostrud exercitation ullamco"+
                                                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute"+
                                                    "irure dolor iLorem ipsum dolor sit amet, consectetur adipiscing elit,"+
                                                    "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut"+
                                                    "enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut"+ 
                                                    "g elit, sed do eiusmod tempor incidi",
                                StartDate= Convert.ToDateTime("2017-12-5 00:00:00"),
                                EndDate= Convert.ToDateTime("2018-1-1 00:00:00"),
                                IsFinished= false,
                                UserId= 3 },
                   
                };
                foreach (Campaign campaign in campaigns){
                    context.Campaigns.Add(campaign);
                }
                context.SaveChanges();
            }

            if(context.CampaignLikes.Any()){
                return;
            }
            else {
                var likes = new LikeCampaign[]{
                    
                    new LikeCampaign(){
                        CampaignId = 1,
                        UserId = 1
                    },
                    new LikeCampaign(){
                        CampaignId = 1,
                        UserId = 2
                    },
                    new LikeCampaign(){
                        CampaignId = 1,
                        UserId = 3
                    }
                };
                foreach (LikeCampaign like in likes){
                    context.CampaignLikes.Add(like);
                }
                context.SaveChanges();

            }

            }

        }
    }

}