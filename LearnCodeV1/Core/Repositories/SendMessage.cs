using LearnCodeV1.Core.Services;
using System.Security.Policy;

namespace LearnCodeV1.Core.Repositories
{
    public class SendMessage : ISendMessage
    {
        public int SendSms(int type, string PhoneNumber, string DisplayName)
        {
            string Smspattern = "";
            string displayName = DisplayName.Replace(" ", "_");
            string fromNumber = "0983000505";
            string url = "";
            if(type == 1)
            {
                Smspattern = "3jqa90l7iyvttqf";
            }

            return 0;
        }
    }
}
