﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.getNetSalary());
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o4.EmpNo);


            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
           
          

            Console.ReadLine();

        }
    }
    public class Employee
    {
        private string empName;
        private decimal basicsalary;
        private short deptno;
        
        static int id = 0;

        public Employee()
        {
            EmpNo = 0;
        }
        public Employee(string empName, decimal basicsalary, short deptno)

        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;
            this.BasicSalary = basicsalary;
            this.DeptNo = deptno;
        }
        public Employee(string empName, decimal basicsalary)

        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;
            this.BasicSalary = basicsalary;
            

        }
        public Employee(string empName)

        {
            id++;
            this.EmpNo = id;
            this.EmpName = empName;

        }

        public string EmpName
        {
            set {
                if (value != "xyz")
                    empName = value;
                else
                    Console.WriteLine("invalid name");

            }
            get {

                return empName;
            }

        }

        public int EmpNo
        {
            get;
        }
        public decimal BasicSalary
        {
            set {

                if (value > 1000 && value < 1000000)
                    basicsalary = value;
                else
                    Console.WriteLine("Invalid salary");
            }
            get {

                return basicsalary;
            
            }
        
        }

        public short DeptNo
        {
            set {

                if (value > 0)
                    deptno = value;
                else
                    Console.WriteLine("invalid deptno");
            
            
            }
            get
            {

                return deptno;
            }
        
        
        }

        public decimal getNetSalary()
        {

            decimal tax = 10000;
            decimal pf = 5000;

            decimal salary = basicsalary - tax-pf;
            return salary;

        
        }




    }
}
