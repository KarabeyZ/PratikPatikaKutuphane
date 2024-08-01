using PratikPatikaKutuphane;

Book book1 = new Book();

//parametre gönderilmiyor
Console.WriteLine($"{book1.bookName},{book1.authorName},{book1.page},{book1.publisher},{book1.registrationDate}");

//parametre gönderiliyor
Book book2 = new Book("Aylin Kulin","Adı Aylin","398","Remzi Kitabevi");

Console.WriteLine($"{book2.bookName},{book2.authorName},{book2.page},{book2.publisher},{book2.registrationDate}");
