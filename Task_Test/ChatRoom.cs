public class ChatRoom
{
    private List<Message> messages = new List<Message>();
    private readonly object lockObj = new object();

    public void AddMessage(string sender, string text)
    {
        lock (lockObj)
        {
            Message msg = new Message(sender, text);
            messages.Add(msg);
        }
    }
    public List<Message> GetMessagesFrom(string sender)
    {
        lock (lockObj)
        {
            List<Message> msgs = new List<Message>();
            for (int i = 0; i < messages.Count; i++)
            {
                if (messages[i].sender == sender)
                {
                    msgs.Add(messages[i]);
                }
            }
            return msgs;
        }
    }
    public int GetMessageCount()
    {
        lock (lockObj)
        {
            return messages.Count;
        }
    }
}