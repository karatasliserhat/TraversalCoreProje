using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IUserApiService
    {
        Task<ResponseViewModel<CreateUserViewModel>> CreateUserAsync(CreateUserViewModel model);
    }
}
