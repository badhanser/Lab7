using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class TaiKhoan
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Chọn cơ sở của bạn")]
        public int IdCoSo { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Chưa nhập tên người dùng")]
        [StringLength(32, MinimumLength = 4, ErrorMessage = "Tên tài khoản phải có độ dài 4-32 ký tự")]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa nhập email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa nhập Họ")]
        public string Ho { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa nhập tên đệm")]
        public string TenDem { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa nhập Tên")]
        public string Ten { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa chọn ngày sinh")]
        public DateTime NgaySinh { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập giới tính của bạn")]
        public string GioiTinh { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập SĐT của bạn")]
        public string DienThoai { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập số CCCD của bạn")]
        public string CCCD { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập địa chỉ của bạn")]
        public string DiaChi { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chưa có trạng thái")]
        public string TrangThai { get; set; }
    }
}
