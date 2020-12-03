using System.Collections.Generic;

namespace Walkabouts.Data.Domain
{
    public class UserWallet : BaseEntity
    {
        public long UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }
        public ICollection<PaymentOption> PaymentOptions { get; set; }
        public decimal Balance { get; set; }
    }
}