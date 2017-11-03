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
    public partial class ControlDevices : Form
    {

        //public string ReturnText1 { get; set; }
        //public string ReturnText2 { get; set; }
        public ControlDevices()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var success = await ParticleCloud.SharedCloud.LoginAsync("stathisvotsis@gmail.com", "eystbots");
            ParticleDevice device = await ParticleCloud.SharedCloud.GetDeviceAsync("3c0034001347353136383631");
            var functionResponse = await device.RunFunctionAsync("relayOn", "1");
            var result = functionResponse.ReturnValue;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var success = await ParticleCloud.SharedCloud.LoginAsync("stathisvotsis@gmail.com", "eystbots");
            ParticleDevice device = await ParticleCloud.SharedCloud.GetDeviceAsync("3c0034001347353136383631");
            var functionResponse = await device.RunFunctionAsync("relayOn", "2");
            var result = functionResponse.ReturnValue;
        }
    }
}
