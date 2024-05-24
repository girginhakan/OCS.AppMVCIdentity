
using Microsoft.AspNetCore.Identity;
using OCS.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCS.Entities.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public bool IsSubscriber { get; set; }
        public DateTime? SubscriptionStartDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public int DailyFreeItemCount { get; set; } = 5; // Günlük ücretsiz alınabilecek kahve sayısı
        public DateTime? LastFreeItemDate { get; set; }
        //Buraya birde bir kahve aldıktan sonra diğerini alabilmesi için en az 1 saat geçmesi gerekmektedir ve aynı anda 2 veya daha fazla kahve alınamamaktadır.

        // Navigation properties
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
