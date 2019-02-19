using System;
using CampanhaInfopharma.IRepository;
using CampanhaInfopharma.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampanhaInfopharma.Controllers
{
    [Route("api/[Controller]")]
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardController;
        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardController = dashboardRepository;
        }

        [HttpGet]
        public DashboardDTO GetResults()
        {
            try
            {
                return _dashboardController.GetResults();
            }
            catch (Exception)
            {
                return new DashboardDTO();
            }
        }
    }
}