using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemesterTest_Prac_46463054_Mohlalal
{
    public partial class Form2 : Form
    {
        private const double BaseFund = 15000.00;
        private double amountFunded = 0;
        private double totalFundedAmount = 0;
        int yearsFunded = 0;
        Random random = new Random();

        public Form2()
        {
            InitializeComponent();
            txtName.Focus();
            BackColor = Color.Beige;
            btnProcess.Visible = false;
          
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            // Clear all input fields and reset the form.
            txtName.Clear();
            txtAge.Clear();
            lstEmploymentType.ClearSelected();
            radPreviouslyFundedYes.Checked = false;
            chkConfirmation.Checked = false;
            lstOutput.Items.Clear();
            lstOutput2.Items.Clear();
            totalFundedAmount = 0;
            btnProcess.Visible = false;
            txtName.Focus();
        }

        private void radPreviouslyFundedNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkConfirmation_CheckedChanged(object sender, EventArgs e)
        {
            btnProcess.Visible = true;

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                bool previouslyFunded = radPreviouslyFundedYes.Checked;
               

              
                

                // checking the age 
                 if (age < 18 || age > 36)
                {
                    MessageBox.Show("Applicants must be between 18 and 36 years old.");
                    return;
                }
;

                string selectedEmploymentType = lstEmploymentType.SelectedItem.ToString();
               

                    if (lstEmploymentType.SelectedIndex > -1)
                    {

                        switch (selectedEmploymentType)
                        {
                            case "Employed-Full time":
                                yearsFunded = 3;
                                break;
                            case "Employed-Part time":
                                yearsFunded = 3;
                                break;
                            case "Unemployed":
                                yearsFunded = 3;
                                break;
                            case "Tenderpreneur":
                                yearsFunded = 3;
                                break;
                            case "Self-employed":
                                yearsFunded = 4;
                                break;
                            case "Entreprenuer":
                                yearsFunded = 5;
                                break;
                            default:
                                throw new InvalidOperationException("Invalid employment type.");

                        }
                    }

                int year = 1;
                // bool Funded;
                if (gbPreviousFunding.Enabled)
                {
                    if (radPreviouslyFundedYes.Checked == true)
                    {
                        lstOutput.Items.Add($"Funding Application for {name} ");
                        amountFunded = BaseFund + 25000;
                        while (year <= yearsFunded)
                        {
              
                            //Display to the listBox as output
                            lstOutput.Items.Add($"Year {year} will be {amountFunded} with payout reference {GenerateReferenceNumber():D6}");
                            totalFundedAmount += amountFunded;
                            year++;
                        }
                        lstOutput.Items.Add($"Total Funded Amount: {totalFundedAmount:C}");
                    }
                    else if(radPreviouslyFundedNo.Checked == true)
                    {
                        lstOutput.Items.Add($"Funding Application for {name} ");
                        amountFunded = BaseFund + 40000;
                        while (year <= yearsFunded)
                        {

                            //Display to the listBox as output
                            lstOutput.Items.Add($"Year {year} will be {amountFunded} with payout reference {GenerateReferenceNumber():D6}");
                            totalFundedAmount += amountFunded;
                            year++;
                        }
                        lstOutput.Items.Add($"If approved, the total Funded Amount, will be {totalFundedAmount:C}");
                    }
                    else
                    {
                        MessageBox.Show("Please select previous funding");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private int GenerateReferenceNumber()
        {
           
            return random.Next(100000, 999999);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.CheckFileExists == false)
                {
                    string sPath = "save.txt";
                    StreamWriter SaveFile = new StreamWriter(sPath);
                    foreach (var item in lstOutput.Items)
                    {
                        SaveFile.WriteLine(item.ToString());
                    }
                    SaveFile.Close();
                }

                saveFileDialog1.InitialDirectory = @"C:\";    
                saveFileDialog1.Title = "Save As";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try 
            {
               
                openFileDialog1.Title = "Open Text File";
                openFileDialog1.Filter = "TXT files|*.txt";
                openFileDialog1.InitialDirectory = @"C:\";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName.ToString()))
                    {
                        // Reads file line by line 
                        StreamReader Textfile = new StreamReader(openFileDialog1.FileName.ToString());
                        string line;

                        while ((line = Textfile.ReadLine()) != null)
                        {
                            lstOutput2.Items.Add(line);
                        }

                        Textfile.Close();
                    }
                }
            }
            catch(Exception exep)
            {
                MessageBox.Show($"Error: {exep.Message}");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }



