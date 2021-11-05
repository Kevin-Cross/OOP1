using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Book : Media
    {
        //public int ID { get; set; }
        //public string Title { get; set; }
        //public string Publisher { get; set; }
        //public string Creator { get; set; }
        //public DateTime PublishDate { get; set; }
        //public int Pages { get; set; }
        //public ReadingLevel ReadingLevel { get; set; }

        //public int GetAge(DateTime publishDate)
        //{
        //    return publishDate.Year - DateTime.Now.Year;
        //}

        //public void Print()
        //{
        //    Console.WriteLine("Book.Print()");
        //}
        private int _ID;
        private string _Title { get; set; }
        private string _Publisher { get; set; }
        private string _Creator { get; set; }
        private DateTime _PublishDate { get; set; }
        private int _Pages { get; set; }
        private ReadingLevel _ReadingLevel { get; set; }

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (value > 0 && value <= int.MaxValue)
                {
                    _ID = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("ID", "ID must be a positive integer.");
                }
            }
        }
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Title = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Title", "Title can not be blank.");
                }

            }
        }
        public string Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Publisher = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Publisher", "Publisher can not be blank.");
                }
            }
        }
        public string Creator
        {
            get
            {
                return _Creator;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _Creator = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Creator", "Creator can not be blank.");
                }
            }
        }
        public DateTime PublishDate
        {
            get
            {
                return _PublishDate;
            }
            set
            {
                if (value > new DateTime(1878, 01, 01))
                {
                    _PublishDate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("PublishDate", "PublishDate must be after 1/1/1878.");
                }
            }
        }
        public int Pages
        {
            get
            {
                return _Pages;
            }
            set
            {
                if (value > 0)
                {
                    _Pages = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("RunLength", "RunLength must be a positive integer with seconds rounded up to the next minute.");
                }
            }

        }
        public ReadingLevel ReadingLevel
        {
            get
            {
                return _ReadingLevel;
            }
            set
            {
                if (value == ReadingLevel.Adult || value == ReadingLevel.Teen || value == ReadingLevel.Kids || value == ReadingLevel.YoungAdult)
                {
                    _ReadingLevel = value;
                }
            }
        }


        public Book() : this(0, string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0, ReadingLevel.Unknown)
        { }

        public Book(int iD, string title, string publisher, string creator, DateTime publishDate, int Pages, ReadingLevel readingLevel)
        {
            ID = iD;
            Title = title;
            Publisher = publisher;
            Creator = creator;
            PublishDate = publishDate;
            Pages = _Pages;
            ReadingLevel = readingLevel;
        }

        public int GetAge(DateTime publishDate)
        {
            return DateTime.Now.Year - PublishDate.Year;
        }

        public void Print()
        {
            Console.WriteLine(String.Format("{0,10}{1,10}{2,15}{3,15}{4,15}{5,20:MM/dd/yyyy}{6,10}{7,10}{8,10}", "Book:", ID, Title, Publisher, Creator, PublishDate, GetAge(this.PublishDate), Pages, ReadingLevel));
        }
    }
}
