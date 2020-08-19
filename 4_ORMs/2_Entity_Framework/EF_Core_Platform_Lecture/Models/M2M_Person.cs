using System.Collections.Generic;

namespace EF_Core_Platform_Lecture.Models
{
    public class M2M_Person
    {
        public int M2M_PersonId { get; set; }
        public string M2M_Name { get; set; }
        public List<M2M_Subscription> M2M_Subscriptions { get; set; }
    }
}