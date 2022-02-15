using System;
using System.Collections.Generic;
using System.Text;

namespace Harvard_Referencing_Program
{
    class Book : Publication
    {
        public Book(string _firstName, string _lastName, int _yearPublished, string _title) : base(_firstName, _lastName, _yearPublished, _title, PublicationType.Book) { }
        public Book(string _firstName, string _lastName, string _title) : base(_firstName, _lastName, _title, PublicationType.Book) { }
    }
}
