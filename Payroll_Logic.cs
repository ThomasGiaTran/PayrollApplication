//========================== LOGIC ===============================
//Author:                   Thomas Tran
//Author's email:           trangiadat86@gmail.com
//Course:                   CPSC223N
//Assignment number:        Assignment 2
//Due date:                 Feb 25, 2015
//========================== LOGIC ===============================

using System;
using System.Drawing;
using System.Windows.Forms;

public class Payroll_Logic
{
    public static string CombineName(string x, string y)
    {
        return x.ToUpper() + " " + y.ToUpper();
    }
    public static double ComputeRegularPay(double x, double y)
    {
        if (x > 40)
            return 40 * y;
        else
            return x * y;
    }
    public static double ComputeOvertimePay(double x, double y)
    {
        if (x > 40)
            return (x - 40) * (1.5 * y);
        else
            return 0;
    }
    public static double ComputeGrossPay(double x, double y)
    {
        return x + y;
    }
    public static double ComputeWithholdTax(double x, double y)
    {
        double taxPercent = (20 - ((x + 1) * 2)) / 100;
        return taxPercent * y;
    }
    public static double ComputeHealth(double x)
    {
        return 85 + x * 54;
    }
    public static double ComputeSSecurity(double x)
    {
        if (.04 * x < 30)
            return .04 * x;
        else
            return 30;
    }
    public static double ComputeNetPay(double x, double y, double z, double n)
    {
        return (x - y - z - n);
    }
} //End of Payroll_Logic

