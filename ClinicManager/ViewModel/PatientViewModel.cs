using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Model
{
       public class PatientViewModel
       {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string FullName
            {
                get
                {
                    return FirstName + " " + SecondName;
                }
            }
            public string Email { get; set; }
            public DateTimeOffset BirthDate { get; set; }
            public int Age
            {
                get 
                {
                    return DateTime.Now.Year - BirthDate.Year;  
                 }
            }
            public string InsuranceNumber { get; set; }
            public string PhoneNumber { get; set; }
            public string Photo { get; set; }
            public string Comment { get; set; }

           public static PatientViewModel FromModel(Patient model)
           {
               PatientViewModel pvm = new PatientViewModel();
                    pvm.SecondName = model.SecondName;
                    pvm.Email = model.Email;
                    pvm.BirthDate = model.BirthDate;
                    pvm.PhoneNumber = model.PhoneNumber;
                    pvm.Photo = model.Photo;
                    pvm.InsuranceNumber = model.InsuranceNumber;
                    pvm.FirstName = model.FirstName;
               return pvm;
           }
        }
}
