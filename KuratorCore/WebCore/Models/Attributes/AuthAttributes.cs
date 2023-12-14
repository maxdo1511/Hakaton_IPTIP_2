using System.ComponentModel.DataAnnotations;

namespace WebCore.Models.Attributes;

    /// <summary>
    /// Checks if name is not admin and does not contain invalid symbols.
    /// </summary>
    public class LoginAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is string userName)
            {
                if (userName.ToLower() != "admin" && !userName.Contains(" ")) 
                {
                    return true;
                }
                else
                {
                    ErrorMessage = "Недопустимое имя пользователя "+userName;
                }
                    
            }
            return false;
        }
    }
    /// <summary>
    /// Checks if name is not admin and does not contain invalid symbols.
    /// </summary>
    public class EmailAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is string email)
            {
                if (email.ToLower() != "admin" && !email.Contains(" ")) 
                {
                    return true;
                }
                else
                {
                    ErrorMessage = "Недопустимый адрес электронной почты "+email;
                }
                        
            }
            return false;
        }
    }
    /// <summary>
    /// Checks if password contains invalid symbols.
    /// </summary>
    public class PasswordAttribute : ValidationAttribute
    {
        
        public override bool IsValid(object? value)
        {
            if (value is string password)
            {
                bool flag = false;
                foreach (var item in "\"';<>?/{}[]@#$%^&*()-+=_ ")
                {
                    if (password.Contains(item))
                    {
                        flag = true;
                    }
                }
                int lettersUpperCount = 0;
                int lettersLowerCount = 0;
                int numbersCount = 0;
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        lettersUpperCount += 1;
                    }
                    if (char.IsLower(c))
                    {
                        lettersLowerCount += 1;
                    }
                    if (char.IsNumber(c))
                    {
                        numbersCount += 1;
                    }
                }
                if (flag == true && numbersCount >= 1 && lettersLowerCount >= 1 && lettersUpperCount >= 1  && !password.Contains(" "))
                {
                    return true;
                }
                else if (numbersCount < 1 || lettersUpperCount < 1 || lettersLowerCount < 1)
                {
                    if (flag == false)
                    {
                        ErrorMessage = "В пароле должны быть специальные символы, и хотя бы одна цифра, строчная и заглавная буквы";
                    }
                    

                    ErrorMessage = "В пароле должна быть хотя бы одна цифра, строчная буква и заглавная буква!";
                    
                }
            }
            return false;
        }
    }
    /// <summary>
    /// Checks if id is null or less than zero.
    /// </summary>
    public class IdAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is int id)
            {
                if (id > 0)
                {
                    return true; 
                }
                else
                {
                    ErrorMessage = "Invalid user id!";
                }
            }
            return false;
        }

    }
   