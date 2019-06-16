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
    public partial class EducationReview : UserControl
    {
        public EducationReview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.btnSearchClick != null)
            {
                this.btnSearchClick(this, e);
            }
        }

        public event EventHandler btnSearchClick;

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

      
    }
}
