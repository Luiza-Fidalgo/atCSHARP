using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LuizaWebApp.DadosFlores;

namespace LuizaWebApp.Controller1
{
    public class FloresControllers : Controller
    {
        private readonly FloresDbContext _context;

        public FloresControllers(FloresControllers context)
        {
            _context = context; 
        }
    }
}
