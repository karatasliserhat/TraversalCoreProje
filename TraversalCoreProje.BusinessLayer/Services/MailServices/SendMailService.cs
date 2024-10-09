using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using MimeKit;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;
using TraversolCoreProje.Dto.Dtos.BaseDto;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class SendMailService : ISendMailService
    {
        public async Task<ResponseDto<MailRequestDto>> SendMail(MailRequestDto mailRequestDto)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "serhatkaratasli790@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequestDto.ReceiverMail);
            mimeMessage.From.Add(mailboxAddressTo);

            mimeMessage.Subject = mailRequestDto.Subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequestDto.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("serhatkaratasli790@gmail.com", "qyhhpozaaxbevbhf");
          
             smtpClient.Send(mimeMessage);
            await smtpClient.DisconnectAsync(true);

            return ResponseDto<MailRequestDto>.Success(mailRequestDto, StatusCodes.Status200OK);

        }
    }
}
