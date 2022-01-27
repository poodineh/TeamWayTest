using System.ComponentModel.DataAnnotations;

namespace Management.Domain.Workers
{
    public partial class Worker
    {
        public Worker(string userName, string email) : base()
        {
            UserName = userName;
            Email = email;
        }

        public bool ValidOnAdd()
        {
            return
                // Validate userName
                !string.IsNullOrEmpty(UserName)
                // Make sure email not null and correct email format
                && !string.IsNullOrEmpty(Email)
                && new EmailAddressAttribute().IsValid(Email);
        }
    }
}
