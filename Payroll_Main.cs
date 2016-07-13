//========================== MAIN ===================================
//Author:                   Thomas Tran
//Author's email:           trangiadat86@gmail.com
//Course:                   CPSC223N
//Assignment number:        Assignment 2
//Due date:                 Feb 25, 2015
//========================== MAIN ===================================

using System;
using System.Windows.Forms;

public class Payroll_Main
{
    static void Main()
    {
        System.Console.WriteLine("Welcome to the Main method of the Payroll aplication.");
        Payroll_Interface Payrollapp = new Payroll_Interface();
        Application.Run(Payrollapp);
        System.Console.WriteLine("Main method will now shutdown.");
    }//End of Main
}//End of Payroll_Main
