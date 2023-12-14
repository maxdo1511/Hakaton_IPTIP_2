using LogicCore.Communicators;

namespace LogicCore.Logic;

public class NotificationLogic
{
    private EmailCommunicator _emailCommunicator;
    private DatabaseCommunicator _databaseCommunicator;
    public NotificationLogic(EmailCommunicator emailCommunicator,DatabaseCommunicator databaseCommunicator)
    {
        _emailCommunicator = emailCommunicator;
        _databaseCommunicator = databaseCommunicator;
    }

    public async Task Notify()
    {
        
    }

    public async Task ManageNotifications()
    {
        var users = _databaseCommunicator.GetSortedCurators("none");
        //TODO Get Notifications
        List<DateTime> notifications = new List<DateTime>();
        foreach (var VARIABLE in notifications)
        {
            if (DateTime.Today - VARIABLE == TimeSpan.FromDays(5))
            {
                //TODO Work with notifications
            }
        }
    }
}