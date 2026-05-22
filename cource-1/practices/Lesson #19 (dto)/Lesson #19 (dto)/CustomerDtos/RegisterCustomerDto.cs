using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
public class RegisterCustomerDto
{
    [Required(ErrorMessage = "Имя пользователя обязательно")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Имя должно быть от 3 до 50 символов")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный формат Email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Пароль обязателен")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Пароль должен быть не менее 8 символов")]
    public string Password { get; set; }
    [Range(18, 100, ErrorMessage = "Возраст должен быть от 18 до 100 лет")]
    public int Age { get; set; }
}