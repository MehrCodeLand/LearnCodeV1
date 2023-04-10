namespace LearnCodeV1.Core.Services
{
    public interface ISendMessage
    {
        int SendSms(int type, string PhoneNumber, string DisplayName);
    }
}
