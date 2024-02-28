﻿namespace DesignPattern.Decorator.DAL
{
    public class Notifier
    {
        public int NotifierID { get; set; }
        public string NotifierCreator { get; set; } //notifieri oluşturan kişi
        public string NotifierSubject { get; set; }
        public string NotifierType { get; set; }
        public string NotifierChannel { get; set; }
    }
}
