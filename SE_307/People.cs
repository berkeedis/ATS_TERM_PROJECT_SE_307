using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_307
{
    class People
    {
        private string username;
        private string password;
        private List<ATS> ats;
        public People(string username, string password, List<ATS> ats)
        {
            this.username = username;
            this.password = password;
            this.ats = ats;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        internal List<ATS> Ats { get => ats; set => ats = value; }
    }
}
