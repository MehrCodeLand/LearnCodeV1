using LearnCodeV1.Core.Services;
using LearnCodeV1.Data.Models;
using LearnCodeV1.Data.MyDb;
using LearnCodeV1.Data.ViewModels;
using LearnCodeV1.Extra.Creator;
using LearnCodeV1.Extra.Security;

namespace LearnCodeV1.Core.Repositories
{
    public class MainRepo : IMainService
    {
        private readonly myDb _db;
        public MainRepo(myDb db)
        {
            _db = db;
        }

        private int IsPhoneNumber(string phonenumber)
        {
            return 0;
        }
      
        
        public int RegisterUser(SignUpVm signUp)
        {

            User user = new User()
            {
                MyUserId = CreateUserId.CreateId(),
                Username = signUp.fName + " " + signUp.lNmae,
                Password = HashPasswordC.EncodePasswordMd5(signUp.Password),
                ConfirmCode = $"{CreateUserId.CreateId()}",
                PhoneNumber = signUp.PhoneNumber,
                Avatar = "user.jpg",
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            return 110 ;
        }


    }
}
