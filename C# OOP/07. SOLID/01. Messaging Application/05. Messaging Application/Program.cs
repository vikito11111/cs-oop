using _05._Messaging_Application;

List<IMessageSender> messageSenders = new List<IMessageSender>();

IMessageSender smsSender = new SmSSender();

IMessageSender emailSender = new EmailSender();

messageSenders.Add(smsSender);
messageSenders.Add(emailSender);

foreach (var messageSender in messageSenders)
{
    messageSender.SendMessage(Console.ReadLine());
}