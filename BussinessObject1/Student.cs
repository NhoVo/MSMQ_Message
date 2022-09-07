using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject1
{
    [Serializable]
    public class Student
    {
        public long StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public Student():this(0,"no-name",new DateTime()) { }
        public Student(long studentId, string fullName, DateTime dOB)
        {
            StudentId = studentId;
            FullName = fullName;
            DOB = dOB;
        }
        public override string ToString()
        {
            return FullName+"\t"+DOB;
        }
    }
}
