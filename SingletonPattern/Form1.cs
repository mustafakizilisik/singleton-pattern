using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            Socket client = SocketConnection.GetClient(txtIPAddress.Text.ToString(), Convert.ToInt32(txtPort.Text));
            if (client.Connected)
            {
                lblConnectionStatus.Text = "Connection Started...";
            }
            else
            {
                lblConnectionStatus.Text = "An error occurred while connecting";
            }
        }
    }
}
