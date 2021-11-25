using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section6Properties
{
    class Members
    {
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        public int age;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is {memberName},my job title is {jobTitle} and I'm {age} years old");
            }
        }

        private void sharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 600000;
            jobTitle = "developer";
            Console.WriteLine("object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            //cleanup statements
            Console.WriteLine("deconstruction of members object");
            Debug.Write("destruction of members object");
        }
    }
}
