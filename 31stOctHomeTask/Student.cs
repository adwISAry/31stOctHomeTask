using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31stOctHomeTask
{
    public class Student
    {

        
        public int Id {get ; set; }
        public string FullName { get; set; }

        public string GroupNo { get; set; }

        public int Age { get; set; }

        private static int nextId = 1;

        public Student(int id, string fullname, string groupNo, int age)
        {
            Id = nextId++;
            FullName = fullname;
            GroupNo = groupNo;
            Age = age;
        }


        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 4 || !Char.IsLetter(groupNo[0]))

                return false;
            



        }



        public static bool CheckFullname(string fullname)
        {
            bool foundSpace = false;

            foreach (char space in fullname)
            {
                if (space == ' ')
                {
                    foundSpace = true;
                    break;
                }
            }

            return foundSpace && !string.IsNullOrWhiteSpace(fullname);
        }
    }
}
