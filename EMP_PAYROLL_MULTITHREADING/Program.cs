﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP_PAYROLL_MULTITHREADING
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Payroll Problem Using MultiThreading");
            EmpRepository repository = new EmpRepository();
            repository.DataBaseConnection(); // database connection using the sql connection string

            Console.ReadLine();
        }
    }

}
