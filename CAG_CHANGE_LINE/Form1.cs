using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAG_CHANGE_LINE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DSTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_FPT_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> networkAdapters = GetActiveNetworkAdapters();

            lbl_TenMay.Text = get_PCName();
            lbl_IPAdd.Text = get_IPAddr();
            lbl_NetMask.Text = get_SubnetMark();
            lbl_GetWay.Text = get_Gateway();
            lbl_DNS.Text = get_DNSAddressesAsString();

            cbb_basic.DataSource = networkAdapters;
        }

        private void btn_gg_Click(object sender, EventArgs e)
        {

        }

        private void mni_ReadMe_Click(object sender, EventArgs e)
        {

        }

        private String get_PCName()
        {
            string hostname = System.Environment.MachineName;
            return hostname;

        }

        private String get_IPAddr()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork) // Chỉ lấy IPv4
                {
                    return ip.ToString();
                }
            }
            return null;
        }

        private String get_SubnetMark()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork) // IPv4
                        {
                            return ip.IPv4Mask.ToString();
                        }
                    }
                }
            }
            return string.Empty;
        }

        private String get_Gateway()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (GatewayIPAddressInformation gateway in ni.GetIPProperties().GatewayAddresses)
                    {
                        return gateway.Address.ToString();
                    }
                }
            }
            return string.Empty;
        }

        public static string get_DNSAddressesAsString()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    var dnsList = ni.GetIPProperties().DnsAddresses
                                    .Select(d => d.ToString())
                                    .ToArray();
                    return string.Join("  -  ", dnsList);
                }
            }
            return string.Empty;
        }

        public static List<string> GetActiveNetworkAdapters()
        {
            List<string> adapters = new List<string>();

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up) // Chỉ lấy adapter đang hoạt động
                {
                    adapters.Add($"{ni.Name} - {ni.Description}");
                }
            }

            return adapters;
        }

    }
}
