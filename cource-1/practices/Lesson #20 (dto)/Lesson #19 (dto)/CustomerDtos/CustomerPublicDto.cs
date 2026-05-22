using System;
using System.Collections.Generic;
using System.Text;
public class CustomerPublicDto
{
    private string _firstName;
    private string _lastName;

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
}