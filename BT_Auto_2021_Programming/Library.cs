using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Library
    {
        public static void Librarya(string[] args)
        {
            Book Book1 = new Book(" Medicina Spirituala", 33, "Alberto Villoldo", " Vidia ", 2015);
            Book1.PrintBook();

            Author Author1 = new Author("Alberto Villoldo", "albertovilloldo@gmail.com");
            Author1.PrintAuthor();
        }
    }
}
