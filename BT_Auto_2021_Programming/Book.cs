using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Auto_2021_Programming
{
    class Book
    {
        public String title;
        public double price;
        public String author;
        public String publisher;
        public int year;


        public Book(String title, double price, String author, String publisher, int year)

        {
            this.title = title;
            this.price = price;
            this.author = author;
            this.publisher = publisher;
            this.year = year;

        }

        public String GetTitle()
        {
            return title;
        }
        public double GetPrice()
        {
            return price;
        }
        public String GetAuthor()
        {
            return author;
        }
        public String GetPublisher()
        {
            return publisher;
        }

        public int GetYear()
        {
            return year;
        }


        public void SetTitle(String title)
        {
            this.title = title;
        }
        public void SetAuthor(String author)
        {
            this.author = author;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetPublisher(String publisher)
        {
            this.publisher = publisher;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public void PrintBook()

        {
            Console.WriteLine("Book:" + title + "( Price: " + price +" lei "+")" + publisher + year);

        }

    }
}
