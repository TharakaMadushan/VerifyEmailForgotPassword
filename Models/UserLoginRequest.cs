 namespace VerifyEmailForgotPassword.Models
{
    public class UserLoginRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Please enter minimum 6 characters!")]
        public string Password { get; set; } = string.Empty;
    }
}
