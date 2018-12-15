namespace MessageSchemas
{
    public class Message
    {
        public short Id { get; set; }

        public Message() : this(0) { }

        public Message(short id)
        {
            this.Id = id;
        }
    }
}
