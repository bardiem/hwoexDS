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
    public partial class WorkerChanging : UserControl
    {
        public WorkerChanging()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
            TextBox5.Clear();
            TextBox6.Clear();
            TextBox7.Clear();
            TextBox8.Clear();
            TextBox9.Clear();
            TextBox10.Clear();
            TextBox11.Clear();
            TextBox12.Clear();
            TextBoxID.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.btnDeleteClick != null)
            {
                this.btnDeleteClick(this, e);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if (this.btnDeleteClick != null)
            {
                this.btnDeleteClick(this, e);
            }
        }

        public event EventHandler btnAddClick;
        public event EventHandler btnDeleteClick;
        public event EventHandler tbTextChanged;


        public DataGridView DataView
        {
            get
            {
                return this.dataGridView1;
            }
            set
            {
                dataGridView1 = value;
            }
        }

        public TextBox TextBox1
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

        public TextBox TextBox2
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

        public TextBox TextBox3
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

        public TextBox TextBox4
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

        public TextBox TextBox8
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

        public TextBox TextBox5
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

        public TextBox TextBox6
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

        public TextBox TextBox7
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

        public TextBox TextBox9
        {
            get
            {
                return textBox1;
            }

            set
            {
                textBox1 = value;
            }
        }

        public TextBox TextBox10
        {
            get
            {
                return textBox2;
            }

            set
            {
                textBox2 = value;
            }
        }

        public TextBox TextBox11
        {
            get
            {
                return textBox3;
            }
            set
            {
                textBox3 = value;
            }
        }

        public TextBox TextBox12
        {
            get
            {
                return textBox4;
            }

            set
            {
                textBox4 = value;
            }
        }

        public TextBox TextBoxID
        {
            get
            {
                return tbID;
            }
            set
            {
                tbID = value;
            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (this.tbTextChanged != null)
            {
                this.tbTextChanged(this, e);
            }
        }
    }
}
