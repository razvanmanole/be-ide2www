using System.ComponentModel.DataAnnotations;

namespace ide2www.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}