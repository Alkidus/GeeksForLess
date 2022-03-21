using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTask.Models
{
    public class User
    {
        // ID пользователя
        public int Id { get; set; }
        // Имя пользователя
        public string Name { get; set; }
        // Почта пользователя
        public string Email { get; set; }
        // Пароль пользователя
        public string Password { get; set; }

    }
}