using System.ComponentModel.DataAnnotations;
namespace BaiKiemTra.Models
{
    public class NTNQStudent
    {
        [Key]
        [Display(Name = "Mã SV")]
        public string NTNQStudentID { get; set; }
        [Display(Name = "Tên SV")]

        public string NTNQStudentName { get; set; }
        [Display(Name = "Địa chỉ")]
        public string NTNQAdress { get; set; }
        
    }
}