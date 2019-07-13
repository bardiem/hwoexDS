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
using System.Data.SqlClient;
using System.Collections;

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
            workerReview1.DataView.DataSource = db.FillWorkers(service.GetWorkers());
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            workerReview1.DataView.DataSource = db.FillWorkers(service.GetWorkers());
            sidePanel1.Top = button3.Top;
            sidePanel1.Height = button3.Height;
            HidePanels();
            panel2.Visible = true;
            workerReview1.Visible = true;
            sidePanel2.Top = button1T.Top;
            sidePanel2.Height = button1T.Height;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            HidePanels();
            faq1.Visible = true;

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
                companiesReview1.DataView.DataSource = db.FillExperiance(service.GetExperiances());
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
                educationReview1.DataView.DataSource = db.FillEducation(service.GetEducations());


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
                workerReview1.DataView.DataSource = db.FillWorkers(service.GetWorkers());


            } else if(sidePanel1.Top == button2.Top)
            {
                workerChanging1.Visible = true;
            }
        }


        private void companiesReview1_btnSearchClick(object sender, EventArgs e)
        {
            companiesReview1.DataView.DataSource = db.FillExperiance(service.SelectFromExperiance(companiesReview1.TextBox1.Text, companiesReview1.TextBox2.Text,
    companiesReview1.TextBox3.Text, companiesReview1.TextBox4.Text));
            addUser1.ClearTextBoxes(3);
        }


        private void educationReview1_btnSearchClick(object sender, EventArgs e)
        {
            educationReview1.DataView.DataSource = db.FillEducation(service.SelectFromEducation(educationReview1.TextBox1.Text, educationReview1.TextBox2.Text,
                educationReview1.TextBox3.Text, educationReview1.TextBox4.Text));
            addUser1.ClearTextBoxes(2);
        }

        private void workerReview1_btnSearchClick(object sender, EventArgs e)
        {
            workerReview1.DataView.DataSource = db.FillWorkers(service.SelectFromWorkers(workerReview1.TextBox1.Text, workerReview1.TextBox2.Text,
                workerReview1.TextBox3.Text, workerReview1.TextBox4.Text, workerReview1.TextBox5.Text, workerReview1.TextBox6.Text, workerReview1.TextBox7.Text, workerReview1.TextBox8.Text));
            addUser1.ClearTextBoxes(2);
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
            addUser1.ClearTextBoxes(2);
        }


        private void addUser1_btnAddExperianceClick(object sender, EventArgs e)
        {
            
            service.InsertExperience(addUser1.TextBox1C.Text, addUser1.TextBox2C.Text, addUser1.TextBox3C.Text, addUser1.TextBox4C.Text,
                addUser1.TextBox5C.Text, addUser1.TextBox6C.Text, addUser1.TextBox7C.Text, addUser1.TextBox8C.Text);
            addUser1.ClearTextBoxes(3);
        }


        private void addUser1_btnAddWorkerClick(object sender, EventArgs e)
        {
         
            if (addUser1.TextBox10W.Text == "Необов'язкво")
            {
                addUser1.TextBox10W.Text = "";
            }
            if (addUser1.TextBox11W.Text == "Необов'язкво")
                addUser1.TextBox11W.Text = "";

            if (addUser1.TextBox12W.Text == "Необов'язкво")
                addUser1.TextBox12W.Text = "";
            service.InsertWorker(addUser1.TextBox1W.Text, addUser1.TextBox2W.Text, addUser1.TextBox3W.Text, addUser1.TextBox4W.Text,
                addUser1.TextBox5W.Text, addUser1.TextBox6W.Text, addUser1.TextBox7W.Text, addUser1.TextBox8W.Text,
                addUser1.TextBox9W.Text, addUser1.TextBox10W.Text, addUser1.TextBox11W.Text, addUser1.TextBox12W.Text);
            addUser1.ClearTextBoxes(1);
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
            int i = 0;
            try
            {
                i = int.Parse(companiesChanging1.TextBoxID.Text);
                companiesChanging1.DataView.DataSource = db.FillExperiance(service.GetExperiance(i));
            }
            catch (Exception) { }
            
        }

        private void educationChanging1_tbTextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = int.Parse(educationChanging1.TextBoxID.Text);
                educationChanging1.DataView.DataSource = db.FillEducation(service.GetEducation(i));
            }
            catch (Exception) { }
        }

        private void workerChanging1_tbTextChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = int.Parse(workerChanging1.TextBoxID.Text);
                workerChanging1.DataView.DataSource = db.FillWorkers(service.GetWorker(i));
            }
            catch (Exception) { }
        }

        private void companiesChanging1_btnChangingClick(object sender, EventArgs e)
        {
            string message = "Ви впевненi що хочете оновити запис #" + companiesChanging1.TextBoxID.Text + "?";
            string caption = "Оновлення запису";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                service.UpdateExperiance(int.Parse(companiesChanging1.TextBoxID.Text), companiesChanging1.TextBox1.Text, int.Parse(companiesChanging1.TextBox2.Text),
                    companiesChanging1.TextBox3.Text, companiesChanging1.TextBox4.Text, companiesChanging1.TextBox5.Text, int.Parse(companiesChanging1.TextBox6.Text),
                    companiesChanging1.TextBox7.Text, companiesChanging1.TextBox8.Text);
                companiesChanging1.ClearTextBoxes();
            }
        }

        private void educationChanging1_btnChangeClick(object sender, EventArgs e)
        {
            string message = "Ви впевненi що хочете оновити запис #" + educationChanging1.TextBoxID.Text + "?";
            string caption = "Оновлення запису";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                service.UpdateEducation(educationChanging1.TextBoxID.Text, educationChanging1.TextBox1.Text, educationChanging1.TextBox2.Text,
                    educationChanging1.TextBox3.Text, educationChanging1.TextBox4.Text, educationChanging1.TextBox5.Text, educationChanging1.TextBox6.Text,
                    educationChanging1.TextBox7.Text, educationChanging1.TextBox8.Text);
                educationChanging1.ClearTextBoxes();
            }
        }

        private void workerChanging1_btnAddClick(object sender, EventArgs e)
        {
            string message = "Ви впевненi що хочете оновити запис #" + workerChanging1.TextBoxID.Text + "?";
            string caption = "Оновлення запису";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                service.UpdateWorker(workerChanging1.TextBoxID.Text, workerChanging1.TextBox1.Text, workerChanging1.TextBox2.Text,
                    workerChanging1.TextBox3.Text, workerChanging1.TextBox4.Text, workerChanging1.TextBox5.Text, workerChanging1.TextBox6.Text,
                    workerChanging1.TextBox7.Text, workerChanging1.TextBox8.Text, workerChanging1.TextBox9.Text, workerChanging1.TextBox10.Text,
                    workerChanging1.TextBox11.Text, workerChanging1.TextBox12.Text);
                workerChanging1.ClearTextBoxes();
            }
        }


    }
}
