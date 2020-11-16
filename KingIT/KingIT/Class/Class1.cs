using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KingIT
{
    class Users
    {
        public string Surname { get; set; }

        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public string Role { get; set; }

        public string Gender { get; set; }
        public int TeleNum { get; set; }
        public string Foto { get; set; }
    }
}
