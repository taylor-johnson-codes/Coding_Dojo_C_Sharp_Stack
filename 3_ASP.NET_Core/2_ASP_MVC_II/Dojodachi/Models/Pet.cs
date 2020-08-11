using System.ComponentModel.DataAnnotations;

namespace Dojodachi.Models
{
    public class Pet
    {
        public int Happiness {get;set;} = 20;
        public int Fullness {get;set;} = 20;
        public int Energy {get;set;} = 50;
        public int Meals {get;set;} = 3;
    }
}