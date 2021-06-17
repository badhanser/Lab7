using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab7.Models;

namespace Lab7.IService
{
    public interface ITaiKhoanService
    {
        List<TaiKhoan> GetListTaiKhoan();
        TaiKhoan GetById(int id);
        TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan);
        TaiKhoan EditTaiKhoan(TaiKhoan taiKhoan);
        void DeleteTaiKhoan(int id);
    }
}
