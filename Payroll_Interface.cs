//========================== INTERFACE ===============================
//Author:                   Thomas Tran
//Author's email:           trangiadat86@gmail.com
//Course:                   CPSC223N
//Assignment number:        Assignment 2
//Due date:                 Feb 25, 2015
//========================== INTERFACE ===============================

using System;
using System.Drawing;
using System.Windows.Forms;

public class Payroll_Interface : Form
{
    private Label Title = new Label();
    private Label FirstName = new Label();
    private Label LastName = new Label();
    private Label HoursWorked = new Label();
    private Label PayRate = new Label();
    private Label Dependents = new Label();
    private Label HealthPlan = new Label();
    private Label Name = new Label();
    private Label RegularPay = new Label();
    private Label OvertimePay = new Label();
    private Label GrossPay = new Label();
    private Label WithholdTax = new Label();
    private Label Health = new Label();
    private Label SSecurity = new Label();
    private Label NetPay = new Label();
    private TextBox InputFirstName = new TextBox();
    private TextBox InputLastName = new TextBox();
    private TextBox InputHoursWorked = new TextBox();
    private TextBox InputPayRate = new TextBox();
    private ComboBox DependentsComboBox = new ComboBox();
    private RadioButton YesHealthButton = new RadioButton();
    private RadioButton NoHealthButton = new RadioButton();
    private Label OutputName = new Label();
    private Label OutputRegularPay = new Label();
    private Label OutputOvertimePay = new Label();
    private Label OutputGrossPay = new Label();
    private Label OutputWithholdTax = new Label();
    private Label OutputHealth = new Label();
    private Label OutputSSecurity = new Label();
    private Label OutputNetPay = new Label();
    private Button ComputePayButton = new Button();
    private Button ClearButton = new Button();
    private Button ExitButton = new Button();

    public Payroll_Interface()
    {
        // 
        // Form
        // 
        Size = new Size(400, 560);
        Text = "Payroll Application";
        // 
        // Title
        // 
        Title.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
        Title.Location = new Point(95, 10);
        Title.Size = new Size(243, 25);
        Title.Text = "Tran Enterprises Payroll";
        // 
        // FirstName
        // 
        FirstName.Location = new Point(25, 60);
        FirstName.Size = new Size(60, 13);
        FirstName.Text = "First Name:";
        // 
        // LastName
        // 
        LastName.Location = new Point(200, 60);
        LastName.Size = new Size(61, 13);
        LastName.Text = "Last Name:";
        // 
        // HoursWorked
        // 
        HoursWorked.Location = new Point(25, 90);
        HoursWorked.Size = new Size(80, 13);
        HoursWorked.Text = "Hours worked";
        // 
        // PayRate
        // 
        PayRate.Location = new Point(25, 120);
        PayRate.Size = new Size(46, 13);
        PayRate.Text = "Pay rate";
        // 
        // Dependents
        // 
        Dependents.Location = new Point(25, 150);
        Dependents.Size = new Size(65, 13);
        Dependents.Text = "Dependents";
        // 
        // HealthPlan
        // 
        HealthPlan.Location = new Point(25, 180);
        HealthPlan.Size = new Size(61, 13);
        HealthPlan.Text = "Health plan";
        // 
        // Name
        // 
        Name.Location = new Point(25, 230);
        Name.Size = new Size(38, 13);
        Name.Text = "Name:";
        // 
        // RegularPay
        // 
        RegularPay.Location = new Point(25, 260);
        RegularPay.Size = new Size(67, 13);
        RegularPay.Text = "Regular pay:";
        // 
        // OvertimePay
        // 
        OvertimePay.Location = new Point(25, 290);
        OvertimePay.Size = new Size(72, 13);
        OvertimePay.Text = "Overtime pay:";
        // 
        // GrossPay
        // 
        GrossPay.Location = new Point(25, 320);
        GrossPay.Size = new Size(57, 13);
        GrossPay.Text = "Gross pay:";
        // 
        // WithholdTax
        // 
        WithholdTax.Location = new Point(25, 350);
        WithholdTax.Size = new Size(69, 13);
        WithholdTax.Text = "Withhold tax:";
        // 
        // Health
        // 
        Health.Location = new Point(25, 380);
        Health.Size = new Size(41, 13);
        Health.Text = "Health:";
        // 
        // SSecurity
        // 
        SSecurity.Location = new Point(25, 410);
        SSecurity.Size = new Size(80, 13);
        SSecurity.Text = "Social Security:";
        // 
        // NetPay
        // 
        NetPay.Location = new Point(25, 440);
        NetPay.Size = new Size(47, 13);
        NetPay.Text = "Net pay:";
        // 
        // InputFirstName
        // 
        InputFirstName.Location = new Point(115, 60);
        InputFirstName.Size = new Size(80, 20);
        InputFirstName.Text = ""; //empty string
        // 
        // InputLastName
        // 
        InputLastName.Location = new Point(265, 60);
        InputLastName.Size = new Size(80, 20);
        InputLastName.Text = ""; //empty string
        // 
        // InputHoursWorked
        // 
        InputHoursWorked.Location = new Point(115, 90);
        InputHoursWorked.Size = new Size(80, 20);
        InputHoursWorked.Text = ""; //empty string
        // 
        // InputPayRate
        // 
        InputPayRate.Location = new Point(115, 120);
        InputPayRate.Size = new Size(80, 20);
        InputPayRate.Text = ""; //empty string
        // 
        // DependentsComboBox
        //
        DependentsComboBox.Location = new Point(115, 150);
        DependentsComboBox.Size = new Size(80, 20);
        // Display choices 0-9 in dependent dropdown box
        string[] NumOfDependents = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        DependentsComboBox.Items.AddRange(NumOfDependents);
        // 
        // YesHealthButton
        // 
        YesHealthButton.Location = new Point(115, 180);
        YesHealthButton.Size = new Size(43, 17);
        YesHealthButton.Text = "Yes";
        // 
        // NoHealthButton
        // 
        NoHealthButton.Location = new Point(170, 180);
        NoHealthButton.Size = new Size(39, 17);
        NoHealthButton.Text = "No";
        // 
        // OutputName
        // 
        OutputName.Location = new Point(160, 230);
        OutputName.Size = new Size(240, 20);
        OutputName.Text = ""; //empty string
        // 
        // OutputRegularPay
        // 
        OutputRegularPay.Location = new Point(160, 260);
        OutputRegularPay.Size = new Size(80, 13);
        OutputRegularPay.Text = ""; //empty string
        // 
        // OutputOvertimePay
        // 
        OutputOvertimePay.Location = new Point(160, 290);
        OutputOvertimePay.Size = new Size(80, 13);
        OutputOvertimePay.Text = ""; //empty string
        // 
        // OutputGrossPay
        // 
        OutputGrossPay.Location = new Point(160, 320);
        OutputGrossPay.Size = new Size(80, 13);
        OutputGrossPay.Text = ""; //empty string
        // 
        // OutputWithholdTax
        // 
        OutputWithholdTax.Location = new Point(160, 350);
        OutputWithholdTax.Size = new Size(80, 13);
        OutputWithholdTax.Text = ""; //empty string
        // 
        // OutputHealth
        // 
        OutputHealth.Location = new Point(160, 380);
        OutputHealth.Size = new Size(80, 13);
        OutputHealth.Text = ""; //empty string
        // 
        // OutputSSecurity
        // 
        OutputSSecurity.Location = new Point(160, 410);
        OutputSSecurity.Size = new Size(80, 13);
        OutputSSecurity.Text = ""; //empty string
        // 
        // OutputNetPay
        // 
        OutputNetPay.Location = new Point(160, 440);
        OutputNetPay.Size = new Size(80, 13);
        OutputNetPay.Text = ""; //empty string
        // 
        // ComputePayButton
        // 
        ComputePayButton.Location = new Point(25, 490);
        ComputePayButton.Size = new Size(100, 20);
        ComputePayButton.Text = "Compute Pay";
        //Associate the Compute button with the Enter key of the keyboard
        AcceptButton = ComputePayButton;
        // 
        // ClearButton
        // 
        ClearButton.Location = new Point(140, 490);
        ClearButton.Size = new Size(100, 20);
        ClearButton.Text = "Clear";
        // 
        // ExitButton
        // 
        ExitButton.Location = new Point(250, 490);
        ExitButton.Size = new Size(100, 20);
        ExitButton.Text = "Exit";

        //Associate the Compute button with the Enter key of the keyboard
        AcceptButton = ComputePayButton;

        //Add controls to the form
        Controls.Add(ExitButton);
        Controls.Add(ClearButton);
        Controls.Add(ComputePayButton);
        Controls.Add(OutputNetPay);
        Controls.Add(OutputSSecurity);
        Controls.Add(OutputHealth);
        Controls.Add(OutputWithholdTax);
        Controls.Add(OutputGrossPay);
        Controls.Add(OutputOvertimePay);
        Controls.Add(OutputRegularPay);
        Controls.Add(OutputName);
        Controls.Add(NoHealthButton);
        Controls.Add(YesHealthButton);
        Controls.Add(DependentsComboBox);
        Controls.Add(InputPayRate);
        Controls.Add(InputHoursWorked);
        Controls.Add(InputLastName);
        Controls.Add(InputFirstName);
        Controls.Add(NetPay);
        Controls.Add(SSecurity);
        Controls.Add(Health);
        Controls.Add(WithholdTax);
        Controls.Add(GrossPay);
        Controls.Add(OvertimePay);
        Controls.Add(RegularPay);
        Controls.Add(Name);
        Controls.Add(HealthPlan);
        Controls.Add(Dependents);
        Controls.Add(PayRate);
        Controls.Add(HoursWorked);
        Controls.Add(LastName);
        Controls.Add(FirstName);
        Controls.Add(Title);

        //Register the event handler.
        ComputePayButton.Click += new EventHandler(ComputePay);
        ClearButton.Click += new EventHandler(cleartext);
        ExitButton.Click += new EventHandler(stoprun);  //The '+' is required.

    }//End of constructor Payroll_Interface

    //Method to execute when the compute button receives an event, namely: receives a mouse click
    protected void ComputePay(Object sender, EventArgs events)
    {
        //Create variables
        string  First_Name, Last_Name;
        int     NumOfDepedents = DependentsComboBox.SelectedIndex;
        double  Hours_Worked, Pay_Rate, Regular_Pay, Overtime_Pay, Gross_Pay, TaxFee, healthFee, SSFee, 
                Net_Pay;

        //Convert variables
        First_Name = Convert.ToString(InputFirstName.Text);
        Last_Name = Convert.ToString(InputLastName.Text);
        Hours_Worked = Convert.ToDouble(InputHoursWorked.Text);
        Pay_Rate = Convert.ToDouble(InputPayRate.Text);

        //Assign variables
        OutputName.Text = Payroll_Logic.CombineName(First_Name, Last_Name);
        Regular_Pay = Payroll_Logic.ComputeRegularPay(Hours_Worked, Pay_Rate);
        Overtime_Pay = Payroll_Logic.ComputeOvertimePay(Hours_Worked, Pay_Rate);
        Gross_Pay = Payroll_Logic.ComputeGrossPay(Regular_Pay, Overtime_Pay);
        SSFee = Payroll_Logic.ComputeSSecurity(Gross_Pay);
        TaxFee = Payroll_Logic.ComputeWithholdTax(NumOfDepedents, Gross_Pay);
        healthFee = Payroll_Logic.ComputeHealth(NumOfDepedents);
        Net_Pay = Payroll_Logic.ComputeNetPay(Gross_Pay, TaxFee, healthFee, SSFee);

        //Convert variables to strings for outputs
        OutputRegularPay.Text = string.Format("{0:N2}", Regular_Pay);
        OutputOvertimePay.Text = string.Format("{0:N2}", Overtime_Pay);
        OutputGrossPay.Text = string.Format("{0:N2}", Gross_Pay);
        OutputWithholdTax.Text = string.Format("{0:N2}", TaxFee);
        if (YesHealthButton.Checked == true)
        {
            OutputHealth.Text = string.Format("{0:N2}", healthFee);
        }
        else
        {
            OutputHealth.Text = "0.00";
        }
        OutputSSecurity.Text = string.Format("{0:N2}", SSFee);
        OutputNetPay.Text = string.Format("{0:N2}", Net_Pay);
    }//End of ComputePay

    //Method to execute when the clear button receives an event, namely: receives a mouse click
    protected void cleartext(Object sender, EventArgs events)
    {
        InputFirstName.Text = "";
        InputLastName.Text = "";
        InputHoursWorked.Text = "";
        InputPayRate.Text = "";
        NoHealthButton.Checked = true;
        DependentsComboBox.ResetText();
    }//End of cleartext

    //Method to execute when the exit button receives an event, namely: receives a mouse click
    protected void stoprun(Object sender, EventArgs events)
    {
        Close();
    }//End of stoprun
}//End of clas Payroll_Interface
