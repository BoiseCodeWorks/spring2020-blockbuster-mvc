using System;

namespace bb_mvc.Models
{
    class Message
    {
        public Message(string body, ConsoleColor color = ConsoleColor.Black)
        {
            Body = body;
            Color = color;
        }

        public string Body { get; set; }
        public ConsoleColor Color { get; set; }
    }
}