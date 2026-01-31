//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using VolunteerHub.Data.DataContext.DataContextVolunteer;
//using VolunteerHub.Core.Models;

//namespace VolunteerHubTest.FakeContext
//{
//    public class FakeContext : IDataContext
//    {
//        public List<Volunteer> volunteer { get; set; }
//        public FakeContext()
//        {
//            volunteer = new List<Volunteer> 
//            {
//                new Volunteer {
//                    Id=177 , 
//                    FullName="sara choen", 
//                    Email="saraChoen@gmail.com" ,
//                    Phone="058-5375523" , 
//                    Status="busy"
//                } ,
//                new Volunteer {  
//                    Id = 123456, 
//                    FullName = "avi rafalowitz", 
//                    Email = "aviRafa@gmail.com", 
//                    Phone = "053-4140552", 
//                    Status = "can"
//                }  
//            };
//        }
//    }
//}
