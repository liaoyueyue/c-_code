using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment5
{
    class Student
    {
        private String username;
        private String password;
        public Student(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

        public void setUsername(String username)
        {
            this.username = username;
            return;
        }

        public void setPassword(String password)
        {
            this.password = password;
            return;
        }
    }
}
