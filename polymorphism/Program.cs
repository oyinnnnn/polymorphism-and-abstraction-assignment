using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class StudentPortal
    {
        string LoginDetails(int matricno, string password)
        {

            //return "A-009344/NGN/KEB/0093";
            return System.Guid.NewGuid().ToString();
        }

        string LoginDetails(int registrationnumber)


            { return System.Guid.NewGuid().ToString(); 
        }
        
        string LoginDetails(string studentfirstname, string studentlastname)


            { return System.Guid.NewGuid().ToString(); 
        }

        string LoginDetails(int IDnumber, int classno)
            
        
               { return System.Guid.NewGuid().ToString(); 
        }

        string LoginDetails(StudentDetails studentDetails)
        {
            //code to reach the school
            string transcript = studentDetails.transcript;
            return System.Guid.NewGuid().ToString();
        }
            
    }

    internal class StudentDetails
    {
        public string transcript;
    }
}
