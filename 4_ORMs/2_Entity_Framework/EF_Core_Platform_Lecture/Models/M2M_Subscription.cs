namespace EF_Core_Platform_Lecture.Models
{
    public class M2M_Subscription
    {
        public int M2M_SubscriptionId { get; set; }
        public int M2M_PersonId { get; set; }
        public int M2M_MagazineId { get; set; }
        public M2M_Person M2M_Person { get; set; }
        public M2M_Magazine M2M_Magazine { get; set; }
    }
}