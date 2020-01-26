using System;

namespace realtime_app.Contracts
{
    public class SendMessageRequestContract
    {
        public Guid ContactUserId { get; set; }

        public Guid SenderId { get; set; }
        
        public string Message { get; set; }

        public int MessageType { get; set; }

        public string AttachmentUrl { get; set; }
    }
}