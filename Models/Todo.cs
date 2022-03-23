using System.ComponentModel.DataAnnotations;

namespace dotnetProject2.Models
{
    public class Todo
    {
        public long Id { get; set; }
        [Required]
        public string TodoName { get; set; }
        public string TodoDone { get; set; } = "false";
    }
}