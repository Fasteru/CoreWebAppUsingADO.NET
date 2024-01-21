using Microsoft.AspNetCore.Mvc;
using Models;
using Repository.Data_Access_Layer.Contracts;

namespace CoreWebAppUsingADO.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetData _getdata;

        public HomeController(IGetData getData)
        {
            _getdata = getData;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<StudentsModel> studentsList  = _getdata.GetStudentsData();
            return View(studentsList);
        }
    }
}
