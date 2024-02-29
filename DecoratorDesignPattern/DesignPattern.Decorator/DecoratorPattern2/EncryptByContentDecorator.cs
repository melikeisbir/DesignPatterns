using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator //içeriği şifreleme
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptContent(Message message)
        {
            message.MessageSender = "Takım Lideri";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 17.00'da Publish yapılacak";
            message.MessageSubject = "Publish";
            string data = "";
            data = message.MessageContent;
            char[] chars = data.ToCharArray(); //karakterleri arraya dönüştürme
            foreach (var item in chars)
            {
                message.MessageContent += Convert.ToChar(item + 3).ToString(); //chara dönüştür itemdan gelen değerin üzerine 3 karakter ekle ötele
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptContent(message);
        }
    }
}
