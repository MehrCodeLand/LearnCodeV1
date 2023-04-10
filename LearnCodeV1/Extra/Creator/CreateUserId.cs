namespace LearnCodeV1.Extra.Creator
{
    public class CreateUserId
    {
        public static int CreateId()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }
    }
}
