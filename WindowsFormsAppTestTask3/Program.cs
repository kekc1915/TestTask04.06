using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Instrumentation;

namespace WindowsFormsAppTestTask3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
      
        }
    }

    class AuthToken
    {
        /// <summary>
        /// Authentication token string.
        /// </summary>
        public String Token { get; set; }
        /// <summary>
        /// Date and time the token expires at (UTC).
        /// </summary>
        public DateTime ExpiresAt { get; set; }
    }

    interface IAuthenticationService
    {
        /// <summary>
        /// Authenticates user.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <returns>Authentication token.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when <paramref name="username"/> or <paramref name="password"/> is null.
        /// </exception>

    }

    interface IUser
    {
        /// <summary>
        /// User's authentication token.
        /// </summary>
        String AuthToken { get; }
    }

    class User : IUser
    {
        private string _username;
        private string _password;
        /// <summary>
        /// Метод преобразующий первую буквы в строке к верхнему регистру 
        /// </summary>
        private string UppercaseFirst(string s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName
        {
            get
            {
                return (UppercaseFirst(_username));
            }

            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(@"Имя должна быть короче 50 символов");
                }
                else _username = value;
            }
        }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(@"password должен быть короче 50 символов");
                }
                else _password = value;
            }
        }
        string IUser.AuthToken
        {
            
            get
            {
                string simpleString = "ABC";
                return simpleString;
            }
        }
        IAuthenticationService authenticationService;
        public void Service(IAuthenticationService service)
        {
            authenticationService = service;

        }
        /*
         1. Реализуйте  class User.
        Класс User реализует interface IUser  и агрегирует в себе инстанс  на абстрактный экземпляр IAuthenticationService.
        2. Напишите как можно больше модульных тестов для класса User (NUnit является предпочтительным, но не обязательным). 
        3. Приложите ссылку на репозиторий с решением заданий.
        */

    }
}
