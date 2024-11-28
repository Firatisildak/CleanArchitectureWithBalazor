using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Request.Account
{
    public class CreateAccountDTO : LoginDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required, Compare(nameof(Password))]//burda compare Password ve ConfirmPassword birbirine eşit mi onu kontrol eder
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        public string Role { get; set; }=string.Empty;
    }
}
