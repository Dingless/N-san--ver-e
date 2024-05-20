public class Book
{
    //De tre publika variablerna
       // Privata variabler för bokens namn, antal sidor och aktuell sida
   private string name;
   private int pages;
   private int currentPage = 0;
 // här är en konstruktör som tar emot boknamn och antal sidor
   public Book(string n, int p)
   {
       name = n;
       pages = p;
   }
   // Metod för att öka aktuell sida
   public void TurnPage()
   {
       currentPage++;
   }
   // Metod för att hämta aktuell sida
   public int GetCurrentPage()
   {
       return currentPage;
   } public string GetName()
   {
       return name;
   }
     // Metod för att hämta antal sidor i boken
   public int GetPages()
   {
       return pages;
   }

// Skapa tre instanser av Book och ge varje instans ett eget namn och antal sidor
Book book1 = new Book("The Great Gatsby", 180);
Book book2 = new Book("To Kill a Mockingbird", 281);
Book book3 = new Book("1984", 328);
// Testa den publika variabeln och metoden genom att köra metoden på någon av Book-instanserna
book2.TurnPage(); // Ökar currentPage för book1 med 1
int currentPage = book2.GetCurrentPage(); // Hämtar aktuell sida för book1
string bookName = book2.GetName(); // Hämtar bokens namn
int bookPages = book2.GetPages(); // Hämtar bokens antal sidor
 
} 
 