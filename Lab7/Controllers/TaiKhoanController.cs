using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab7.IService;
using Lab7.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab7.Controllers
{
    [Authorize]
    public class TaiKhoanController : Controller
    {
        private ITaiKhoanService _iTaiKhoanService;

        public TaiKhoanController(ITaiKhoanService iTaiKhoanService)
        {
            _iTaiKhoanService = iTaiKhoanService;
        }
        public IActionResult Index()
        {
            try
            {
                var lstTaiKhoan = _iTaiKhoanService.GetListTaiKhoan();
                return View(lstTaiKhoan);
            }
            catch (Exception e)
            {
                return View();
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TaiKhoan tk)
        {
            if (!ModelState.IsValid)
            {
                return View(tk);
            }
            _iTaiKhoanService.AddTaiKhoan(tk);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var tk = _iTaiKhoanService.GetById(id);
            return View(tk);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TaiKhoan tk)
        {
            if (!ModelState.IsValid)
            {
                return View(tk);
            }

            _iTaiKhoanService.EditTaiKhoan(tk);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var tk = _iTaiKhoanService.GetById(id);
            return View(tk);
        }
        [HttpPost]
        public IActionResult DeleteTk(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                        _iTaiKhoanService.DeleteTaiKhoan(id);
                    
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction("Index");
            }
        }
    }
}
