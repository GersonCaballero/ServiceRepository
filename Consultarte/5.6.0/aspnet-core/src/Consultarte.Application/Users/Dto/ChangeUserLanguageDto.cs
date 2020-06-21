using System.ComponentModel.DataAnnotations;

namespace Consultarte.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}