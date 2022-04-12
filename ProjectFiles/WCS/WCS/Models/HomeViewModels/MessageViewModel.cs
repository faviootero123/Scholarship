using System.ComponentModel.DataAnnotations;

namespace WCS.Models.HomeViewModels
{
    public class MessageViewModel
    {
        public string Title { get; set; }

        public string Body { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public string ApplicationStatus { get; set; }

        public string ApplicationOpens { get; set; }

        public string ApplicationCloses { get; set; }
    }
}
