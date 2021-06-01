using Microsoft.VisualStudio.TestTools.UnitTesting;
using EMP_PAYROLL_MULTITHREADING;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmployeePayrollMultithreadingTest
{
    // TC1 :- To test for addition of multiple data to the list without using the multi-thread*/
    [TestClass]
    public class UnitTest1
    {
        // Creating an instance of the employee payroll class  so as to invoke the adding methods for records.
        public static EmpModel emp = new EmpModel();
        public static EmpRepository employeeRepository = new EmpRepository();

        [TestMethod]
        public void GivenListOfEmployeesWhenAddedToList_ShouldMatchTheEntriesWithoutThreading()
        {
            //Arrange
            List<EmpModel> employeeList = new List<EmpModel>();
            employeeList.Add(new EmpModel(employeeName: "Rohit", startDate: new System.DateTime(2019, 08, 01), phoneNumber: 4567876543, address: "Bangalore", department: "HR", gender: "M", basicPay: 50000, deductions: 2000, taxablePay: 48000, tax: 1000, netPay: 47000));
            employeeList.Add(new EmpModel(employeeName: "Sachin", startDate: new System.DateTime(2020, 01, 01), phoneNumber: 4563784678, address: "Chennai", department: "HR", gender: "M", basicPay: 50000, deductions: 2000, taxablePay: 48000, tax: 1000, netPay: 47000));
            employeeList.Add(new EmpModel(employeeName: "Yuvraj", startDate: new System.DateTime(2020, 02, 01), phoneNumber: 7865678765, address: "Mumbai", department: "Sales", gender: "M", basicPay: 60000, deductions: 2000, taxablePay: 58000, tax: 1000, netPay: 57000));
            employeeList.Add(new EmpModel(employeeName: "Bumrah", startDate: new System.DateTime(2019, 02, 01), phoneNumber: 3456765434, address: "Delhi", department: "Marketing", gender: "M", basicPay: 60000, deductions: 2000, taxablePay: 58000, tax: 1000, netPay: 57000));
            employeeList.Add(new EmpModel(employeeName: "Pery", startDate: new System.DateTime(2020, 04, 12), phoneNumber: 4567898754, address: "Bangalore", department: "Sales", gender: "F", basicPay: 60000, deductions: 2000, taxablePay: 58000, tax: 1000, netPay: 57000));
            bool expected = true;
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            bool actual = emp.AddEmployeeListToDataBase(employeeList);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time: " + stopwatch.ElapsedMilliseconds);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        private bool AddEmployeeListToDataBase(List<EmpModel> employeeList)
        {
            throw new NotImplementedException();
        }

        // TC2:- To test for addition of multiple data to the list using the multi-threading concept*/
        [TestMethod]
        public void GivenEmployeeList_AddEmployeeListToDatabaseUsingThreads()
        {
            //Arrange
            List<EmpModel> employeeList = new List<EmpModel>();
            employeeList.Add(new EmpModel(employeeName: "Himanshu", startDate: new System.DateTime(2019, 08, 01), phoneNumber: 4567876543, address: "Bangalore", department: "HR", gender: "M", basicPay: 50000, deductions: 2000, taxablePay: 48000, tax: 1000, netPay: 47000));
            employeeList.Add(new EmpModel(employeeName: "Ekta", startDate: new System.DateTime(2020, 01, 01), phoneNumber: 4563784678, address: "Chennai", department: "HR", gender: "F", basicPay: 50000, deductions: 2000, taxablePay: 48000, tax: 1000, netPay: 47000));
            employeeList.Add(new EmpModel(employeeName: "OM", startDate: new System.DateTime(2020, 02, 01), phoneNumber: 7865678765, address: "Mumbai", department: "Sales", gender: "M", basicPay: 60000, deductions: 2000, taxablePay: 58000, tax: 1000, netPay: 57000));
            employeeList.Add(new EmpModel(employeeName: "Vishal", startDate: new System.DateTime(2019, 02, 01), phoneNumber: 3456765434, address: "Delhi", department: "Marketing", gender: "M", basicPay: 60000, deductions: 2000, taxablePay: 58000, tax: 1000, netPay: 57000));
            employeeList.Add(new EmpModel(employeeName: "Kawasaki", startDate: new System.DateTime(2020, 04, 12), phoneNumber: 4567898754, address: "Bangalore", department: "Sales", gender: "M", basicPay: 60000, deductions: 2000, taxablePay: 58000, tax: 1000, netPay: 57000));
            Stopwatch stopwatch = new Stopwatch();

            //Act
            stopwatch.Start();
            employeeRepository.AddEmployeeListToEmployeePayrollDataBaseWithThread(employeeList);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time using the threads: " + stopwatch.ElapsedMilliseconds);
        }
    }
}