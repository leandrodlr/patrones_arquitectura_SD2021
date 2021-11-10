using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatWebApplication
{
    public class Message
    {

        public Message()
        {
            Date = DateTime.Now;
        }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }

        public string IP { get; set; }
    }

    //singleton
    public class ChatRoom
    {
        private ChatRoom()
        {
            Messages = new List<Message>();
        }

        private static ChatRoom instance { get; set; }

        public List<Message> Messages { get; set; }

        public static ChatRoom getInstance()
        {
            if (instance == null)
                instance = new ChatRoom();
            return instance;
        }
    }
}