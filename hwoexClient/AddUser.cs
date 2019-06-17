using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwoexClient
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }
        public void ClearTextBoxes(int i)
        {
            if (i == 1)
            {
                textBox1W.Text = "";
                textBox2W.Text = "";
                textBox3W.Text = "";
                textBox4W.Text = "";
                textBox5W.Text = "";
                textBox6W.Text = "";
                textBox7W.Text = "";
                textBox8W.Text = "";
                textBox9W.Text = "";
                textBox10W.Text = "";
                textBox11W.Text = "";
                textBox12W.Text = "";
            } else if (i == 2)
            {
                textBox1E.Text = "";
                textBox2E.Text = "";
                textBox3E.Text = "";
                textBox4E.Text = "";
                textBox5E.Text = "";
                textBox6E.Text = "";
                textBox7E.Text = "";
                textBox8E.Text = "";
            }
            else if (i == 3)
            {
                textBox1C.Text = "";
                textBox2C.Text = "";
                textBox3C.Text = "";
                textBox4C.Text = "";
                textBox5C.Text = "";
                textBox6C.Text = "";
                textBox7C.Text = "";
                textBox8C.Text = "";
            }
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10W.ForeColor = Color.Black;
            textBox10W.Text = "";
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11W.ForeColor = Color.Black;
            textBox11W.Text = "";

        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9W.ForeColor = Color.Black;
            textBox9W.Text = "";
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1W.Text == "" || textBox2W.Text == "" || textBox3W.Text == "" || textBox4W.Text == "" || textBox5W.Text == "" || textBox6W.Text == "" ||
                textBox7W.Text == "" || textBox8W.Text == "" || textBox12W.Text == "")
            {
                MessageBox.Show(
                 "Заповніть всі обо'язкові поля!",
                 "Повідомлення",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Stop);
            }
            else
            {
                label1.Text = "Дані про освіту";
                panel1.Show();
                
            }


            if (this.btnAddWorkerClick != null)
            {
                this.btnAddWorkerClick(this, e);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1E.Text == "" ||textBox2E.Text == "" || textBox3E.Text == "" || textBox4E.Text == "" || 
                textBox5E.Text == "" || textBox6E.Text == "" || textBox7E.Text == "" || textBox8E.Text == "")
            {
                MessageBox.Show(
                 "Заповніть всі обо'язкові поля!",
                 "Повідомлення",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Stop);
            }
            else
            {
                label1.Text = "Дані про роботу";
                panel1.Hide();
                panel2.Show();
                

            }

            if (this.btnAddEducationClick != null)
            {
                this.btnAddEducationClick(this, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (this.btnAddExperianceClick != null)
            {
                this.btnAddExperianceClick(this, e);
            }

            panel2.Hide();

        }



        private void textBox2C_Click(object sender, EventArgs e)
        {
            textBox2C.ForeColor = Color.Black;
            textBox2C.Text = "";
        }

        private void textBox3C_Click(object sender, EventArgs e)
        {
            textBox3C.ForeColor = Color.Black;
            textBox3C.Text = "";
        }

        private void textBox4C_Click(object sender, EventArgs e)
        {
            textBox4C.ForeColor = Color.Black;
            textBox4C.Text = "";
        }


        public event EventHandler btnAddWorkerClick;
        public event EventHandler btnAddExperianceClick;
        public event EventHandler btnAddEducationClick;



        public TextBox TextBox1C
        {
            get
            {
                return textBox1C;
            }

            set
            {
                textBox1C = value;
            }
        }

        public TextBox TextBox2C
        {
            get
            {
                return textBox2C;
            }

            set
            {
                textBox3C = value;
            }
        }

        public TextBox TextBox3C
        {
            get
            {
                return textBox3C;
            }
            set
            {
                textBox3C = value;
            }
        }

        public TextBox TextBox4C
        {
            get
            {
                return textBox4C;
            }

            set
            {
                textBox4C = value;
            }
        }

        public TextBox TextBox5C
        {
            get
            {
                return textBox5C;
            }

            set
            {
                textBox5C = value;
            }
        }

        

        public TextBox TextBox6C
        {
            get
            {
                return textBox6C;
            }
            set
            {
                textBox6C = value;
            }
        }

        public TextBox TextBox7C
        {
            get
            {
                return textBox7C;
            }

            set
            {
                textBox7C = value;
            }
        }



        public TextBox TextBox8C
        {
            get
            {
                return textBox8C;
            }

            set
            {
                textBox8C = value;
            }
        }




        public TextBox TextBox1E
        {
            get
            {
                return textBox1E;
            }

            set
            {
                textBox1E = value;
            }
        }

        public TextBox TextBox2E
        {
            get
            {
                return textBox2E;
            }

            set
            {
                textBox3E = value;
            }
        }

        public TextBox TextBox3E
        {
            get
            {
                return textBox3E;
            }
            set
            {
                textBox3E = value;
            }
        }

        public TextBox TextBox4E
        {
            get
            {
                return textBox4E;
            }

            set
            {
                textBox4E = value;
            }
        }

        public TextBox TextBox5E
        {
            get
            {
                return textBox5E;
            }

            set
            {
                textBox5E = value;
            }
        }



        public TextBox TextBox6E
        {
            get
            {
                return textBox6E;
            }
            set
            {
                textBox6E = value;
            }
        }

        public TextBox TextBox7E
        {
            get
            {
                return textBox7E;
            }

            set
            {
                textBox7E = value;
            }
        }



        public TextBox TextBox8E
        {
            get
            {
                return textBox8E;
            }

            set
            {
                textBox8E = value;
            }
        }





        public TextBox TextBox1W
        {
            get
            {
                return textBox1W;
            }

            set
            {
                textBox1W = value;
            }
        }

        public TextBox TextBox2W
        {
            get
            {
                return textBox2W;
            }

            set
            {
                textBox3W = value;
            }
        }

        public TextBox TextBox3W
        {
            get
            {
                return textBox3W;
            }
            set
            {
                textBox3W = value;
            }
        }

        public TextBox TextBox4W
        {
            get
            {
                return textBox4W;
            }

            set
            {
                textBox4W = value;
            }
        }

        public TextBox TextBox5W
        {
            get
            {
                return textBox5W;
            }

            set
            {
                textBox5W = value;
            }
        }



        public TextBox TextBox6W
        {
            get
            {
                return textBox6W;
            }
            set
            {
                textBox6W = value;
            }
        }

        public TextBox TextBox7W
        {
            get
            {
                return textBox7W;
            }

            set
            {
                textBox7W = value;
            }
        }



        public TextBox TextBox8W
        {
            get
            {
                return textBox8W;
            }

            set
            {
                textBox8W = value;
            }
        }



        public TextBox TextBox9W
        {
            get
            {
                return textBox9W;
            }

            set
            {
                textBox9W = value;
            }
        }



        public TextBox TextBox10W
        {
            get
            {
                return textBox10W;
            }
            set
            {
                textBox10W = value;
            }
        }

        public TextBox TextBox11W
        {
            get
            {
                return textBox11W;
            }

            set
            {
                textBox11W = value;
            }
        }



        public TextBox TextBox12W
        {
            get
            {
                return textBox12W;
            }

            set
            {
                textBox12W = value;
            }
        }
    }
}
