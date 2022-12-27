using FileAppAPI.BL;
using FileAppAPI.Entities;

namespace FileAppAPI
{
    public class BLFile : IFile
    {
        private readonly IMailService mailService;
        public BLFile(IMailService mailService)
        {
            this.mailService = mailService;
        }
        public void AddNewFile(FileModel f)
        {
            if (f.fileSize > 100000000)
            {
                MailRequest req = new MailRequest();
                //fill data in request:
                req.Body = "Large file...." + f.fileName;
                //.................etc...

                this.mailService.SendEmailAsync(req);
            }

            //buisness to insert a newb file....

        }
    }
}
