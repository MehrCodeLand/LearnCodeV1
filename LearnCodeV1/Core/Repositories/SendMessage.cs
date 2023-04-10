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
            string apiKey = "S-E7VwpdRmkEkDkmepYUI3CY7fpnur9n5ciw9-nCXEU=";

            if (type == 1)
            {
                Smspattern = "3jqa90l7iyvttqf";
                url = $"http://ippanel.com/?apikey={apiKey}&paid={Smspattern}&fnum={fromNumber}&tnum={PhoneNumber}&p1=PersonName&p2=ComplexName&v1{displayName}&v2={displayName}";
            }

            return 0;
        }
    }
}
