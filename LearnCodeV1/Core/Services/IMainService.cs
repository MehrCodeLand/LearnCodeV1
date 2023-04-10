using LearnCodeV1.Data.ViewModels;

namespace LearnCodeV1.Core.Services
{
    public interface IMainService
    {
        int RegisterUser(SignUpVm signUp);
    }
}
