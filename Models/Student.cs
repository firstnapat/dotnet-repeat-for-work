

using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Student
    {
        [Key] // primary key
        public int Id { get; set; }
        [Required] // not null
        public string Name { get; set; }
        public int Score { get; set; }

    }
}