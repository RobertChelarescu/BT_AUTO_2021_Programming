using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Author
    {
        public String name;
        public String email;

        public Author (String name, String email)
        {
            this.name = name;
            this.email = email;
        }
        public String GetName()
        {
            return name;
        }
        public String GetEmail()
        {
            return email;
        }
        public void SetName(String title)
        {
            this.name = name;
        }
        public void SetEmail(String author)
        {
            this.email = email;
        }

        public void PrintAuthor()
        {
           Console.WriteLine( "Author:" + name + " Email adress:  " + email);
        }
    }
}
