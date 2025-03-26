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
        private bool isPinging = false;
        public Form1()
        {
            InitializeComponent();
            btn_refresh.Click += async (s, e) => await RefreshPing();
            this.Load += async (s, e) => await RefreshPing();
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<string> networkAdapters = GetActiveNetworkAdapters();
            List<string> dnsServers = new List<string> { "8.8.8.8", "208.67.222.222", "9.9.9.9", "1.1.1.1", "185.228.168.9" };

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

        private void mnu_Menu_Click(object sender, EventArgs e)
        {

        }

        private async Task RefreshPing()
        {
            List<string> dnsList = new List<string> { "1.1.1.1", "8.8.8.8", "9.9.9.9", "208.67.222.222", "185.228.168.9" }; // Danh sách DNS
            Label[] labels = { lbl_GooglePing, lbl_OpenDNSPing, lbl_SingaporePing, lbl_CloudPing, lbl_VerizonPing }; // Gán từng Label tương ứng

            for (int i = 0; i < dnsList.Count; i++)
            {
                long pingTime = await PingDNS(dnsList[i]);
                if(pingTime< 35)
                {
                    labels[i].ForeColor = Color.Green;
                }
                else if(pingTime < 40)
                {
                    labels[i].ForeColor = Color.Orange;
                }
                else
                {
                    labels[i].ForeColor = Color.Red;
                }
                labels[i].Text = $"{pingTime} ms";
            }
        }

        private async Task<long> PingDNS(string dns)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = await ping.SendPingAsync(dns, 1000); // Timeout 1 giây
                    return reply.Status == IPStatus.Success ? reply.RoundtripTime : -1;
                }
                catch
                {
                    return -1; // Ping thất bại
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
