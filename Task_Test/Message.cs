public class Message
{
    public string sender {  get; set; }
    public string text { get; set;}
    DateTime timeStamp;

    public Message(string sender, string text)
    {
        this.sender = sender;
        this.text = text;
        this.timeStamp = DateTime.Now;
    }
}