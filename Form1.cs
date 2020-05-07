/*
 * IS320 take home exam
 * created by Anya Romines on 12.03.2019
 * app to store data on taxpayers using class + properties
 * inputs: name, salary, investment income, exemption count, marital status
 * outputs: display, computes taxable income/tax rate/tax amount
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //STEP 1 in save and load

namespace ARomines
{
    public partial class Form1 : Form
    {       
        //globals for saving
        private bool savedBool = true; //tracks if there is data that needs to be saved

        private String taxpayerLine; //output from save() in taxpayer
        private String taxpayerFile = ""; //filename as in C:\users\...\outputs.txt -- initialized to nothing
        
        //married and unmarried lists
        private List<Taxpayer> MarriedList = new List<Taxpayer>();
        private List<Taxpayer> UnmarriedList = new List<Taxpayer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click( object sender, EventArgs e )
        {
            EnableControls();
            GetReady();
        }

        private void loadButton_Click( object sender, EventArgs e )
        {
            //read data from a text file
            String taxpayerFile;

            OpenFileDialog taxpayerFileChooser = new OpenFileDialog();
            taxpayerFileChooser.Filter = "All text files|*.txt";
            taxpayerFileChooser.ShowDialog();
            taxpayerFile = taxpayerFileChooser.FileName;
            taxpayerFileChooser.Dispose();

            if(taxpayerFile == "") //protect from crashing if user clicks cancel with if statement
            {
                //do nothing related to load
            }
            else
            {
                using (StreamReader fileReader = new StreamReader(taxpayerFile))
                {
                    while (fileReader.EndOfStream == false)
                    {
                        String[] properties; //an 'array': list is an array on steroids
                        String line;

                        //update these declarations to match your object
                        String taxpayername; //input to constructor
                        double salary;  //input to constructor
                        double investment;
                        int exemption;
                        bool married;

                        line = fileReader.ReadLine();
                        properties = line.Split(',');

                        //update these lines to match your object
                        taxpayername = properties[0];
                        salary = int.Parse(properties[1]);
                        investment = double.Parse(properties[2]);
                        exemption = int.Parse(properties[3]);
                        married = bool.Parse(properties[4]);
                        Taxpayer newTaxpayer;
                        newTaxpayer = new Taxpayer(taxpayername, salary, investment, exemption, married);
                        taxpayerBindingSource.Add(newTaxpayer);

                        if (married == true)
                        {
                            MarriedList.Add(newTaxpayer);
                        }
                        else
                        {
                            UnmarriedList.Add(newTaxpayer);
                        }
                        //end if statement
                    }
                    //end while
                }
                //end stream reader

                //set saved bool to false upon loading data
                savedBool = false;
            }            
        }

        private void saveButton_Click( object sender, EventArgs e )
        {
            if (savedBool == true)
            { MessageBox.Show("No data to save."); }
            else
            {
                if(taxpayerFile == "") //if we don't have save file
                {
                    GetSaveName();
                    if (taxpayerFile == "")
                    {
                        //do nothing related to save
                    }
                    else
                    {
                        SaveData();
                    }
                    //end if statement
                }
                else //extra credit attempt: subsequent saves give the user an option to save to a different file. 
                {
                    DialogResult userChoice = MessageBox.Show("Save to existing file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (userChoice == DialogResult.No)
                    {
                        GetSaveName();
                        if (taxpayerFile != "")
                        { SaveData(); }
                        else
                        { 
                            //do nothing related to save
                        }
                        //end if statement
                    }
                    else
                    { SaveData(); }
                    //end if statement
                }
                //end if statement

                            
            }                
        }

        private void displayButton_Click( object sender, EventArgs e )
        {
            if(MarriedList.Count == 0 && UnmarriedList.Count == 0)
            {
                MessageBox.Show("No data available.");
            }
            else
            {
                //display married taxpayers
                if (MarriedList.Count > 0)
                {
                    outputTextBox.AppendText("Married Taxpayers:" + "\r\n");
                    foreach (Taxpayer person in MarriedList)
                    {
                        outputTextBox.AppendText(person.Info() + "\r\n");
                    }
                }
                else
                { outputTextBox.AppendText("No married taxpayers." + "\r\n"); }
                //end if statement

                //display unmarried taxpayers
                if (UnmarriedList.Count > 0)
                {
                    outputTextBox.AppendText("\r\n" + "Unmarried Taxpayers:" + "\r\n");
                    foreach (Taxpayer person in UnmarriedList)
                    {
                        outputTextBox.AppendText(person.Info() + "\r\n");
                    }
                }
                else
                { outputTextBox.AppendText("No unmarried taxpayers." + "\r\n"); }
                //end if statement
            }
            //end if statement
        }

        private void summaryButton_Click( object sender, EventArgs e )
        {
            if (taxpayerDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data available.");
            }
            else
            {
                outputTextBox.AppendText(Taxpayer.Summary() + "\r\n");
            }
            //end if statement
        }

        private void resetButton_Click( object sender, EventArgs e )
        {//extra credit attempt: app does not crash on cancel, app proceeds to reset without save upon cancel click
            //must have data to reset
            if (MarriedList.Count == 0 && UnmarriedList.Count == 0)
            {
                MessageBox.Show("No data available.");
            }
            else
            {
                //must save data before resetting
                if (savedBool == false)
                {
                    MessageBox.Show("There is unsaved data.");

                    if (taxpayerFile == "")
                    {
                        GetSaveName();
                        if(taxpayerFile != "")
                        {
                            SaveData();
                            ResetData();
                        }
                        //end if statement

                        ResetData();
                    }
                    else
                    {
                        DialogResult userChoice = MessageBox.Show("Save to existing file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (userChoice == DialogResult.No)
                        {
                            GetSaveName();
                            if (taxpayerFile != "")
                            { SaveData(); }
                        }
                        //end if statement

                        ResetData();
                    }
                    //end if statement
                }
                else
                {
                    ResetData();
                }
                //end if statement
            }
            //end if statement
        }

        private void exitButton_Click( object sender, EventArgs e )
        {//extra credit attempt: app does not crash on cancel, app proceeds to exit without save upon cancel click
            //must save data before exiting
            if (savedBool == false)
            {
                MessageBox.Show("There is unsaved data.");                             

                if (taxpayerFile == "")
                {
                    GetSaveName();
                    if(taxpayerFile != "")
                    { SaveData(); }
                    //end if statement
                    Application.Exit();
                }
                else
                {
                    DialogResult userChoice = MessageBox.Show("Save to existing file?", "Unsaved Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (userChoice == DialogResult.No)
                    {
                        GetSaveName();
                        if(taxpayerFile != "")
                        { SaveData(); }
                        //end if statement
                    }
                    else
                    { SaveData(); }
                    //end if statement
                                        
                    Application.Exit();
                }
                //end if statment                
            }
            else
            {
                Application.Exit();
            }
            //end if statement    
        }

        private void submitButton_Click( object sender, EventArgs e )
        {
            //declarations
            String nameString;
            double salaryDouble;
            double investmentDouble;
            int exemptionInt;
            bool marriedBool;

            //class
            Taxpayer newTaxpayer;

            //inputs
            nameString = nameTextBox.Text;
            salaryDouble = double.Parse(salaryTextBox.Text);
            investmentDouble = double.Parse(investmentTextBox.Text);
            exemptionInt = int.Parse(exemptionTextBox.Text);
            marriedBool = marriedCheckBox.Checked;

            if (exemptionInt >= 0 && exemptionInt <= 2) //exemption int must be 0, 1, or 2
            {
                //add to class
                newTaxpayer = new Taxpayer(nameString, salaryDouble, investmentDouble, exemptionInt, marriedBool);
                taxpayerBindingSource.Add(newTaxpayer);

                //add to appropriate list
                if (marriedBool == true)
                {
                    MarriedList.Add(newTaxpayer);
                }
                else
                {
                    UnmarriedList.Add(newTaxpayer);
                }
                //end if statement

                //display output
                outputTextBox.AppendText(newTaxpayer.Info() + "\r\n");

                DisableControls();

                //set saved data to false
                savedBool = false;
            }
            else
            {
                MessageBox.Show("Error: exemptions claimed must be 0, 1, or 2");
                exemptionTextBox.SelectAll();
                exemptionTextBox.Focus();
            }
            //end if statement         
        }

        //===============================FORM METHODS===============================
        private void EnableControls()
        {
            submitButton.Visible = true;           

            nameLabel.Visible = true;
            salaryLabel.Visible = true;
            investmentLabel.Visible = true;
            exemptionLabel.Visible = true;

            nameTextBox.Visible = true;
            salaryTextBox.Visible = true;
            investmentTextBox.Visible = true;
            exemptionTextBox.Visible = true;
            marriedCheckBox.Visible = true;
        }
        private void DisableControls()
        {
            submitButton.Visible = false;
            
            nameLabel.Visible = false;
            salaryLabel.Visible = false;
            investmentLabel.Visible = false;
            exemptionLabel.Visible = false;

            nameTextBox.Visible = false;
            salaryTextBox.Visible = false;
            investmentTextBox.Visible = false;
            exemptionTextBox.Visible = false;
            marriedCheckBox.Visible = false;
        }
        private void GetReady()
        {
            nameTextBox.Clear();
            salaryTextBox.Clear();
            investmentTextBox.Clear();
            exemptionTextBox.Clear();
            marriedCheckBox.Checked = false;
            nameTextBox.Focus();
        }
        private void GetSaveName()
        {
            SaveFileDialog taxpayerFileChooser;

            //Stage 1: collect a filename from user
            taxpayerFileChooser = new SaveFileDialog();
            taxpayerFileChooser.Filter = "All text files|*.txt";
            
            //if user chooses cancel
            if (taxpayerFileChooser.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Data not saved.");
                nameTextBox.Focus();
            }
            //end if statement

            taxpayerFile = taxpayerFileChooser.FileName;
            taxpayerFileChooser.Dispose();
        }
        private void SaveData()
        {
            if (taxpayerDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data available.");
            }
            else
            {
                StreamWriter fileWriter;

                //stage 2: write data to the specified filename
                fileWriter = new StreamWriter(taxpayerFile, false); //false specified for overwrite

                foreach (Taxpayer person in taxpayerBindingSource)
                {
                    taxpayerLine = person.Save();
                    fileWriter.WriteLine(taxpayerLine);
                }

                fileWriter.Close();
                fileWriter.Dispose();  //Destructor

                //display message box saved to file name
                MessageBox.Show("Saved to: " + taxpayerFile.ToString());
            }
            //end if statement

            //set saved bool to true upon saving data
            savedBool = true;
        }
        private void ResetData()
        {
            Taxpayer.ResetCounts();
            MarriedList.Clear();
            UnmarriedList.Clear();
            savedBool = true;
            taxpayerBindingSource.Clear();
            outputTextBox.Clear();
            GetReady();
        }
    }
}
