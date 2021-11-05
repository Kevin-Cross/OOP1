using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Movie : Media
    {
        private int _ID;
        private string _Title { get; set; }
        private string _Publisher { get; set; }
        private string _Creator { get; set; }
        private DateTime _PublishDate { get; set; }
        private int _RunLength { get; set; }
        private Ratings _Rating { get; set; }

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
        public int RunLength
        {
            get
            {
                return _RunLength;
            }
            set
            { if (value > 0)
                {
                    _RunLength = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("RunLength", "RunLength must be a positive integer with seconds rounded up to the next minute.");
                }
            }

        }
        public Ratings Rating
        {
            get
            {
                return _Rating;
            }
            set
            {
                if (value == Ratings.G || value ==Ratings.PG || value == Ratings.PG13 || value == Ratings.R || value == Ratings.Unknown)
                {
                    _Rating = value;
                }
            }
        }
        

        public Movie() : this(0, string.Empty, string.Empty, string.Empty, DateTime.MinValue, 0, Ratings.Unknown)
        { }

        public Movie(int iD, string title, string publisher, string creator, DateTime publishDate, int runLength, Ratings rating)
        {
            ID = iD;
            Title = title;
            Publisher = publisher;
            Creator = creator;
            PublishDate = publishDate;
            RunLength = runLength;
            Rating = rating;
        }

        public int GetAge(DateTime publishDate)
        {
            return DateTime.Now.Year - PublishDate.Year;
        }

        public void Print()
        {
            Console.WriteLine(String.Format("{0,10}{1,10}{2,15}{3,15}{4,15}{5,20:MM/dd/yyyy}{6,10}{7,10}{8,10}","Movie:", ID, Title, Publisher, Creator, PublishDate, GetAge(this.PublishDate), RunLength, Rating));
        }
    }
}
