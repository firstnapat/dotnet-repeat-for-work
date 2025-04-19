

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Student
    {
        [Key] // primary key
        public int Id { get; set; }
        [Required] // not null
        [DisplayName("ชื่อนักเรียน")]
        public string Name { get; set; }
        [DisplayName("คะแนนสอบ")]
        [Range(0, 100, ErrorMessage = "คะแนนสอบต้องอยู่ระหว่าง 0 ถึง 100")]
        public int Score { get; set; }

    }
}