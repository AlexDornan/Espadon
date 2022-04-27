﻿namespace Espadon.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> Users { get; set; }
        public ChatType Type { get; set; }
    }
}