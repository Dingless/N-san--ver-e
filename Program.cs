public class Book
{
    //De tre publika variablerna
    public string Name{get;set;}
    public int pages {get;set;}
    public int currentpage {get;set;} = 0;
    public void turnpage(){
        currentpage++;
    }
}
// tre instanser av variabeln 
    Book book1 = new Book {Name = "The Great Gatsby", pages = 180};
    Book book2 = new Book {Name = "To kill a mockingbird", pages = 281};
    Book book3 = new Book {Name = "1984", pages = 328};
    