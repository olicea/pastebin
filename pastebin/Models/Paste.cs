namespace pastebin.Models;

public class Paste
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
    public string ShortUrl { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ExpirationDate { get; set; }
}