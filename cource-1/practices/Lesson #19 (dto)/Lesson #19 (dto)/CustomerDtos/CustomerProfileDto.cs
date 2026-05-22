using System;
using System.Collections.Generic;
using System.Text;
public class CustomerProfileDto
{
    private string _email;
    private string _firstName;
    private string _lastName;

    public string Email
    {
        get => _email;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                throw new ArgumentException(" Email не может быть пустым и должен содержать '@'.");
            _email = value;
        }
    }

    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Имя не может быть пустым.");
            _firstName = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Фамилия не может быть пустой.");
            _lastName = value;
        }
    }
    public string PhoneNumber { get; set; }
    public string CardNumber { get; set; }
    public string Role { get; set; }
    public bool IsBlocked { get; set; }
    public DateTime CreatedAt { get; set; }
}