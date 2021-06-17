using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab7.Context;
using Lab7.IService;
using Lab7.Models;

namespace Lab7.Service
{
    public class TaiKhoanService:ITaiKhoanService
    {
        private readonly PQVContext _context;
        private List<TaiKhoan> _lstTaiKhoan;
        public TaiKhoanService(PQVContext context)
        {
            _context = context;
            GetListTaiKhoan();
        }
        public List<TaiKhoan> GetListTaiKhoan()
        {
            _lstTaiKhoan = _context.TaiKhoan.ToList();
            return _lstTaiKhoan;
        }

        public TaiKhoan GetById(int id)
        {
            return _lstTaiKhoan.FirstOrDefault(x => x.Id == id);
        }

        public TaiKhoan AddTaiKhoan(TaiKhoan taiKhoan)
        {
            _context.TaiKhoan.Add(taiKhoan);
            _context.SaveChangesAsync();
            return taiKhoan;
        }

        public TaiKhoan EditTaiKhoan(TaiKhoan taiKhoan)
        {
            var tk = _lstTaiKhoan.FirstOrDefault(x => x.Id == taiKhoan.Id);
            if (tk != null)
            {
                tk.Username = taiKhoan.Username;
                tk.Password = taiKhoan.Password;
                tk.Email = taiKhoan.Email;
                tk.Ho = taiKhoan.Ho;
                tk.TenDem = taiKhoan.TenDem;
                tk.Ten = taiKhoan.Ten;
                tk.NgaySinh = taiKhoan.NgaySinh;
                tk.GioiTinh = taiKhoan.GioiTinh;
                tk.DienThoai = tk.DienThoai;
                tk.CCCD = taiKhoan.CCCD;
                tk.DiaChi = taiKhoan.DiaChi;
                tk.TrangThai = taiKhoan.TrangThai;
            }

            _context.TaiKhoan.Update(tk);
            _context.SaveChangesAsync();
            return taiKhoan;
        }

        public void DeleteTaiKhoan(int id)
        {
            var tk = _lstTaiKhoan.FirstOrDefault(x => x.Id == id);
            _context.TaiKhoan.Remove(tk);
            _context.SaveChangesAsync();
        }
    }
}
