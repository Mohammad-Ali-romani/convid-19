using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class employee
    {
        public int empId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Marks { get; set; }
        public employee(int a,string b,string c,int d)
        {
            empId = a; Name = b; Gender = c; Marks = d;
        }
    }
}