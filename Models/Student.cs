using System.ComponentModel.DataAnnotations;

namespace DemoMVCHung.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; } = default!;

        public string HoTen { get; set; } = default!;

        public int Tuoi { get; set; } = default!;

        public double Diem { get; set; } = default!;

        public string Email { get; set; } = default!;
    }
}