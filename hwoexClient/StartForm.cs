using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using hwoexClient.Service;


namespace hwoexClient
{
    public partial class StartForm : Form
    {
        private UseDB db = new UseDB();
        private Service1Client service;

        public StartForm()
        {
            service = new Service1Client();
            InitializeComponent();
        }


        private void StartForm_Load(object sender, EventArgs e)
        {
            workerReview1.DataView.DataSource = db.FillWorkers();
            companiesReview1.DataView.DataSource = db.FillExperiance();
            educationReview1.DataView.DataSource = db.FillEducation();
        }


        private void Login()
        {
            string servPassword = db.GetPassword();
            string clientPassword = textBox1.Text;
            if (clientPassword == servPassword)
            {
                panel1.Visible = true;
                panel3.Visible = true;
                workerReview1.Visible = true;
                button1P.Visible = true;
                button2P.Visible = false;
                button3P.Visible = false;
            }
            else
            {
                MessageBox.Show(
                  "Ви ввели невірний пароль, повторіть спробу",
                  "Повідомлення",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
        }

        private void HidePanels()
        {
            educationChanging1.Visible = false;
            educationReview1.Visible = false;
            companiesChanging1.Visible = false;
            companiesReview1.Visible = false;
            workerReview1.Visible = false;
            workerChanging1.Visible = false;
            faq1.Visible = false;
            addUser1.Visible = false;
        }

     

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bSubmitEnter_Click(object sender, EventArgs e)
        {
            Login();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel1.Top = button1.Top;
            sidePanel1.Height = button1.Height;
            HidePanels();
            addUser1.Visible = true;
            panel2.Visible = false;
            button1P.Visible = false;
            button2P.Visible = false;
            button3P.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel1.Top = button2.Top;
            sidePanel1.Height = button2.Height;
            HidePanels();
            panel2.Visible = true;
            workerChanging1.Visible = true;
            sidePanel2.Top = button1T.Top;
            sidePanel2.Height = button1T.Height;
            button1P.Visible = true;
            button2P.Visible = false;
            button3P.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel1.Top = button3.Top;
            sidePanel1.Height = button3.Height;
            HidePanels();
            panel2.Visible = true;
            workerReview1.Visible = true;
            sidePanel2.Top = button1T.Top;
            sidePanel2.Height = button1T.Height;
            button1P.Visible = true;
            button2P.Visible = false;
            button3P.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HidePanels();
            faq1.Visible = true;
            button1P.Visible = false;
            button2P.Visible = false;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void button3T_Click(object sender, EventArgs e)
        {
            sidePanel2.Top = button3T.Top;
            sidePanel2.Height = button3T.Height;
            HidePanels();
            if (sidePanel1.Top == button3.Top)
            {
                companiesReview1.Visible = true;
                button1P.Visible = false;
                button2P.Visible = false;
                button3P.Visible = true;
            }
            else if (sidePanel1.Top == button2.Top)
            {
                companiesChanging1.Visible = true;

            }
        }

        private void button2T_Click(object sender, EventArgs e)
        {
            sidePanel2.Top = button2T.Top;
            sidePanel2.Height = button2T.Height;

            HidePanels();


            if (sidePanel1.Top == button3.Top)
            {
                educationReview1.Visible = true;
                button1P.Visible = false;
                button2P.Visible = true;
                button3P.Visible = false;

            }
            else if (sidePanel1.Top == button2.Top)
            {
                educationChanging1.Visible = true;
            }
        }

        private void button1T_Click(object sender, EventArgs e)
        {
            sidePanel2.Top = button1T.Top;
            sidePanel2.Height = button1T.Height;

            HidePanels();

            if (sidePanel1.Top == button3.Top)
            {
                workerReview1.Visible = true;
                button1P.Visible = true;
                button2P.Visible = false;
                button3P.Visible = false;

            } else if(sidePanel1.Top == button2.Top)
            {
                workerChanging1.Visible = true;
            }
        }

        private void companiesReview1_Load(object sender, EventArgs e)
        {

        }

        private void workerReview1_btnSearchClick(object sender, EventArgs e)
        {
            
        }

        private void button3P_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void button1P_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void button2P_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void addUser1_btnAddEducationClick(object sender, EventArgs e)
        {
            
            service.InsertEducation(addUser1.TextBox1E.Text, addUser1.TextBox2E.Text, addUser1.TextBox3E.Text, addUser1.TextBox4E.Text,
                addUser1.TextBox5E.Text, addUser1.TextBox6E.Text, addUser1.TextBox7E.Text, addUser1.TextBox8E.Text);
        }

        private void addUser1_btnAddExperianceClick(object sender, EventArgs e)
        {

            service.InsertExperience(addUser1.TextBox1C.Text, addUser1.TextBox2C.Text, addUser1.TextBox3C.Text, addUser1.TextBox4C.Text,
                addUser1.TextBox5C.Text, addUser1.TextBox6C.Text, addUser1.TextBox7C.Text, addUser1.TextBox8C.Text);
        }

        private void addUser1_btnAddWorkerClick(object sender, EventArgs e)
        {
         
            service.InsertWorker(addUser1.TextBox1W.Text, addUser1.TextBox2W.Text, addUser1.TextBox3W.Text, addUser1.TextBox4W.Text,
                addUser1.TextBox5W.Text, addUser1.TextBox6W.Text, addUser1.TextBox7W.Text, addUser1.TextBox8W.Text,
                addUser1.TextBox9W.Text, addUser1.TextBox10W.Text, addUser1.TextBox11W.Text, addUser1.TextBox12W.Text);
        }

        private void companiesChanging1_btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Ви впевненi що хочете видалити запис №" + companiesChanging1.TextBoxID.Text+ "?";
            string caption = "Видалення запису";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes) { 
                service.DeleteTable("Experiance", int.Parse(companiesChanging1.TextBoxID.Text));
                companiesChanging1.ClearTextBoxes(); 
            }

        }

        private void educationChanging1_btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Ви впевненi що хочете видалити запис №" + educationChanging1.TextBoxID.Text + "?";
            string caption = "Видалення запису";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes) { 
                service.DeleteTable("Education", int.Parse(educationChanging1.TextBoxID.Text));
                educationChanging1.ClearTextBoxes();
            }

        }

        private void workerChanging1_btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Ви впевненi що хочете видалити запис #" + workerChanging1.TextBoxID.Text + "?";
            string caption = "Видалення запису";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                service.DeleteTable("Worker", int.Parse(workerChanging1.TextBoxID.Text));
                workerChanging1.ClearTextBoxes();
            }

        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            service.Close();
        }

        private void companiesChanging1_tbTextChanged(object sender, EventArgs e)
        {

        }

        private void educationChanging1_tbTextChanged(object sender, EventArgs e)
        {

        }

        private void workerChanging1_tbTextChanged(object sender, EventArgs e)
        {

        }
    }
}
