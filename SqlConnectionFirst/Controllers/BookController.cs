using Microsoft.AspNetCore.Mvc;
using SqlConnectionFirst.DAL;
using System.Collections.Generic;
using System.Linq;

namespace SqlConnectionFirst.Controllers
{
    public class BookController : Controller
    {
        private readonly DataBase _dataBase;

        public BookController(DataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public IActionResult Index()
        {
            return View(_dataBase.Books.ToList());
        }

        public IActionResult Detail(int id)
        {
            return View(_dataBase.Books.Find(id));
        }
    }
}
