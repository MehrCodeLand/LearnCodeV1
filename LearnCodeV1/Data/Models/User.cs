using System.ComponentModel.DataAnnotations;

namespace LearnCodeV1.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Create { get; set; } = DateTime.Now;
        public string PhoneNumber { get; set; }
        public bool ConfirmPhoneNumber { get; set; }
        public string ConfirmCode { get; set; }
        public bool IsDelete { get; set; }
        public string Avatar { get; set; }
    }
}
