using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikPatikaKutuphane
{
    public class Book
    {
        public string authorName {  get; set; }
        public string bookName { get; set; }
        public string page { get; set; }
        public string publisher { get; set; }
        public DateTime registrationDate { get; set; }

        //Varsayılan Constructor Metot (parametresiz)
        public Book()
        {
            authorName = "Bilinmeyen Yazar";
            bookName = "Bilinmeyen Kitap İsmi";
            page = "Bilinmeyen Sayfa Sayısı";
            publisher = "Bilinmeyen Yayınevi";
            registrationDate = DateTime.Now;
        }
       // Parametreli Constructor Metot
        public Book(string _authorName,string _bookName, string _page, string _publisher)
        {
            authorName = _authorName;
            bookName = _bookName;
            page = _page;
            publisher = _publisher;
            registrationDate = DateTime.Now;
        }

    }
    
}
