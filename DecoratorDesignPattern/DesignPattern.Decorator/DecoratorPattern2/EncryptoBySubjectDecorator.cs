using DesignPattern.Decorator.DAL;
using System;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator //konu decoratorune göre şifreleme
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        //decoratorderki virtuala göre override
        public void SendMessageByEncryptoSubject(Message message)
        {
            message.MessageSender = "İnsan Kaynakları";
            message.MessageReceiver = "Yazılım Ekibi";
            message.MessageContent = "Saat 12.00'da toplantı var";
            message.MessageSubject = "Toplantı";
            string data = "";
            data = message.MessageSubject;
            char[] chars = data.ToCharArray(); //karakterleri arraya dönüştürme
            foreach (var item in chars)
            {
                message.MessageSubject += Convert.ToChar(item + 3).ToString(); //chara dönüştür itemdan gelen değerin üzerine 3 karakter ekle ötele
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message);
        }
    }
}
