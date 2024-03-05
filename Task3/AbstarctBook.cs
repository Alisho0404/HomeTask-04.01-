namespace Task3;

public class AbstarctBook:IReadable
{
    private string _title; 
    private string _author; 

    public string GetTite()
    {
    return _title;
    } 
    public void SetTitle(string title)
    {
        _title=title;
    } 
    public string GetAuthor()
    {
    return _author;
    } 
    public void SetAuthor(string author)
    {
        _author=author;
    }

    public void Read()
    { 
        System.Console.WriteLine("book is being read");
    }
}
