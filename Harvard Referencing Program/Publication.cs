using System;
using System.Collections.Generic;
using System.Text;

namespace Harvard_Referencing_Program
{
    class Publication
    {
        public enum PublicationType 
        {
            Book,
            Journal
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int YearPublished { get; private set; }
        public string Title { get; private set; }

        public PublicationType EntryType { get; private set; }


        public Publication(string _firstName, string _lastName, int _yearPublished, string _title, PublicationType _publicationType) 
        {
            FirstName = _firstName;
            LastName = _lastName;
            YearPublished = _yearPublished;
            Title = _title;
            EntryType = _publicationType;
        }

        public Publication(string _firstName, string _lastName, string _title, PublicationType _publicationType) : this(_firstName, _lastName, -1, _title, _publicationType) { }

        public virtual string BuildBibliographyCitation() 
        {
            if (YearPublished > 0)
            {
                //With publication year
                string returnString = FirstName + ", " + LastName[0].ToString() + "., " + YearPublished + ", " + Title;
                return returnString;
            }
            else 
            {
                //Without publication year
                string returnString = FirstName + ", " + LastName[0].ToString() + "., " + Title;
                return returnString;
            }
        }

        public string BuildInTextCitation(string _text) 
        {
            return _text + ", " + LastName;
        }

    }
}
