using System;
using System.Collections.Generic;
using System.Text;

namespace Harvard_Referencing_Program
{
    class Journal : Publication
    {
       
        public int PageStart { get; set; }
        public int PageEnd { get; set; }

        public Journal(string _firstName, string _lastName, int _yearPublished, string _title, int _pageStart, int _pageEnd) : base(_firstName, _lastName, _yearPublished, _title, PublicationType.Journal) 
        {
            PageStart = _pageStart;
            PageEnd = _pageEnd;
        }
        public Journal(string _firstName, string _lastName, string _title, int _pageStart, int _pageEnd) : base(_firstName, _lastName, _title, PublicationType.Journal) 
        {
            PageStart = _pageStart;
            PageEnd = _pageEnd;
        }

        public override string BuildBibliographyCitation()
        {
            if (YearPublished > 0)
            {
                //With publication year
                string returnString = FirstName + ", " + LastName[0].ToString() + "., " + YearPublished + ", " + Title + ", " + PageStart.ToString() + "-" + PageEnd.ToString();
                return returnString;
            }
            else
            {
                //Without publication year
                string returnString = FirstName + ", " + LastName[0].ToString() + "., " + Title + ", " + PageStart.ToString() + "-" + PageEnd.ToString();
                return returnString;
            }
        }

    }
}
