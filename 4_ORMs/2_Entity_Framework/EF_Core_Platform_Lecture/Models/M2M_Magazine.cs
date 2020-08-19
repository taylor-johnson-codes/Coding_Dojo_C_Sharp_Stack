using System.Collections.Generic;

namespace EF_Core_Platform_Lecture.Models
{
    public class M2M_Magazine
    {
        public int M2M_MagazineId { get; set; }
        public string M2M_Title { get; set; } 
        public List<M2M_Subscription> M2M_Readers { get; set; }
    }
}