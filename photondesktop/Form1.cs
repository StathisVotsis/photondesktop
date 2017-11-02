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
                    MessageBox.Show("Success login");
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch
            {
                MessageBox.Show("Invalid credentials or network error or null credentials");
            }           
        }
    }
}
