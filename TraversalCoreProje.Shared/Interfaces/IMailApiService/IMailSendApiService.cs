using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCoreProje.ViewModels;

namespace TraversalCoreProje.Shared.Interfaces
{
    public interface IMailSendApiService
    {
        Task<ResponseViewModel<MailRequestViewModel>> SendMailAsync(MailRequestViewModel mailRequestViewModel);
    }
}
