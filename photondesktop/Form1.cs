using Particle.SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photondesktop
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var success = await ParticleCloud.SharedCloud.LoginAsync(textBox1.Text, textBox2.Text);
                if (success)
                {
                    DialogResult result = MessageBox.Show("Success Login", "Success",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (result == DialogResult.OK)
                    {
                        ControlDevices cd = new ControlDevices ();
                        cd.ShowDialog();
                        this.Close();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Invalid credentials", "Invalid credentials",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show("Invalid credentials", "Invalid credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
            }           
        }
    }
}
