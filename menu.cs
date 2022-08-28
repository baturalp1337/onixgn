using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Onixgn
{
    public partial class menu : Form
    {
        private static string version = "[version " + "1" + "]";
        public menu()
        {
            InitializeComponent();
            Text = "ONIXGN " + version;
        }

        private static bool ipisinit = false;
        private static string addy = null;

        private static List<int> portlist = new List<int>();
        private static List<string> portliststring = new List<string>();
        private static string output = "";
        private static int maxport = 0;
        private static int minport = 0;
        private static bool portscannerisopen = false;

        private static int packetspammerport = 0;
        private static bool packetspammerisopen = false;

        private void buttonInitIP_Click(object sender, EventArgs e)
        {
            if (textBoxAddy.Text == "")
            {
                ipisinit = false;
                MessageBox.Show("IP Address or Hostname is invalid! Please enter a valid IP Address or Hostname.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ipisinit = true;
                addy = textBoxAddy.Text;
                MessageBox.Show("IP Address or Hostname is initiliazed!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonTogglePortScanner_Click(object sender, EventArgs e)
        {
            portscannerisopen = !portscannerisopen;
            if (portscannerisopen)
            {
                if (!int.TryParse(textBoxMinPort.Text, out minport) || !int.TryParse(textBoxMaxPort.Text, out maxport))
                {
                    portscannerisopen = false;
                    MessageBox.Show("Port ranges are invalid! Please enter a valid port range!");
                }
                else
                {
                    if (maxport > 65535 || minport < 0 || minport >= maxport)
                    {
                        portscannerisopen = false;
                        MessageBox.Show("Port ranges are invalid! Please enter a valid port range!");
                    }
                    else
                    {
                        if (ipisinit)
                        {
                            timerPortScanner.Start();
                            buttonTogglePortScanner.Text = "Stop Scanner";
                        }
                        else
                        {
                            portscannerisopen = false;
                            MessageBox.Show("IP Address or hostname is invalid! Please enter a valid IP Address or hostname.");
                        }
                    }
                }
            }
            else
            {
                timerPortScanner.Stop();
                buttonTogglePortScanner.Text = "Start Scanner";
            }
        }

        private void timerPortScanner_Tick(object sender, EventArgs e)
        {
            if (portscannerisopen)
            {
                if (!ipisinit) 
                { 
                    portscannerisopen = false;
                    buttonTogglePortScanner.Text = "Start Scanner";
                    timerPortScanner.Stop();
                }

                for (int i = minport; i <= maxport; i++)
                {
                    TcpClient tcpclient = new TcpClient();
                    client.tcpconnect(tcpclient, addy, i, true, out output);
                    Console.WriteLine(output);
                    if (output == "Succesfully connected to Address:" + addy.ToString() + " Port:" + i.ToString() + ".")
                    {
                        portlist.Add(i);
                    }
                }

                portliststring = portlist.ConvertAll<string>(x => x.ToString());

                richTextBoxPortScanner.Text = "[ONIXGN Port-Scanner]" + "\nAccesible ports: " + string.Join(",", portliststring);

                portlist.Clear();
                portliststring.Clear();

                portscannerisopen = false;
                buttonTogglePortScanner.Text = "Start Scanner";
                MessageBox.Show("Port scanning is finished!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                timerPortScanner.Stop();
            }
            timerPortScanner.Stop();
        }

        private void timerPacketSpam_Tick(object sender, EventArgs e)
        {
            if (packetspammerisopen)
            {
                if (!ipisinit)
                {
                    packetspammerisopen = false;
                    buttonToggleSpammer.Text = "Start Spammer";
                    timerPacketSpam.Stop();
                }

                TcpClient tcpclient = new TcpClient();
                UdpClient udpclient = new UdpClient();
                if (radioButtonTcp.Checked)
                {
                    if (!client.tcpconnect(tcpclient, addy, packetspammerport, false, out output))
                    {
                        packetspammerisopen = false;
                        buttonToggleSpammer.Text = "Start Spammer";
                        timerPacketSpam.Stop();
                    }
                    Console.WriteLine(output);
                    client.tcpsend(tcpclient, Encoding.ASCII.GetBytes("HlWLQfoxKsic9DysWplfrATRnTXG3AvZQm0CtsE8cRIWue427eivSQn1iLmov7T0eRO2KIyB2ab3T2xGBQ7mjTiSFpkxLuPVvg3Pebv7Y44fsaUtG2LCXyGaP8yQmXIFAJ5zQvAHvIDUY5c5ggOC82K8r9IYNJ5ZdS6nyE1SszONuAGiyQNaI0HTVLIsZRWLMLidkXNKbMHBkCj1W9qxJM9eJxMXutiKhs7fTDP8dBQzQzhaLVNXN6bgRqxAYJK4wngGgLbWnFPPeEFIwWd8EhA6F8K8Ros8VydcqP7uoPSePRYHApMNufNpOfzt1JgzbkSzFfTL5hgNmPL88kl2wL38VEctzos3hFd65JOBcu6kEwyTLfJv7SUmrgSQbpcRiExQNu6amT4XRSZoLUpAE4yThYX5R9OO3e0FHtFHazjKpPLYC7iWWMbJYmujTm8gku5OkxIJlDCEZRwRG19Bri7Epl4ociJwaeUPnyvr3ASPRP3PaUuqUgXftrlsHGPGGbV1OjIB94N64D8zHvKFcEOCTi0c9cMQ5d8DlR86baRgSMcOZ1NnVaNJmwgHFvJITfaDIGmoBmo67kALAbObZgkJ4cBWA4yGPgtNb7BV56o8yF7pLLR066JKWWOI2bUtSjvJm2OwiPbfbmHTA5R2FxKnS4UXfgnVL8Fpx64j2UA5QKnKuJA4XrBIEENB2zHDs485sFFuXnVO0y06CjoAKykMPgEplS7Rq6bRk9owrQChspTb4NOw9y6Izn9mUjpFeAJhkci6vGnVbiIx1ggFMGTunnxEWVoJ6VHCQud6omKSbBUNFWJc8x5ycIN9c6UR4pMPRveghTrE2ZinwrqjYpJCarBVvbB4fBVWLUOvIo9uRyXDeKfvYKinwpnPC0xSP7yeGde0CfGCRv9H8uQLuwDUBUPMFQsEnXLyE9G0J6qkGFht34vde3yYNREU1HgFyjQvPS5nihWWqxJ1zEeVfgukcyYQkbBOKAQDwPn4efrPhaHzVbV50ZhaLzFEIm6x"), out output);
                    Console.WriteLine(output);
                    tcpclient.Close();
                }
                else
                {
                    if (!client.udpconnect(udpclient, addy, packetspammerport, false, out output))
                    {
                        packetspammerisopen = false;
                        buttonToggleSpammer.Text = "Start Spammer";
                        timerPacketSpam.Stop();
                    }
                    Console.WriteLine(output);
                    client.udpsend(udpclient, Encoding.ASCII.GetBytes("HlWLQfoxKsic9DysWplfrATRnTXG3AvZQm0CtsE8cRIWue427eivSQn1iLmov7T0eRO2KIyB2ab3T2xGBQ7mjTiSFpkxLuPVvg3Pebv7Y44fsaUtG2LCXyGaP8yQmXIFAJ5zQvAHvIDUY5c5ggOC82K8r9IYNJ5ZdS6nyE1SszONuAGiyQNaI0HTVLIsZRWLMLidkXNKbMHBkCj1W9qxJM9eJxMXutiKhs7fTDP8dBQzQzhaLVNXN6bgRqxAYJK4wngGgLbWnFPPeEFIwWd8EhA6F8K8Ros8VydcqP7uoPSePRYHApMNufNpOfzt1JgzbkSzFfTL5hgNmPL88kl2wL38VEctzos3hFd65JOBcu6kEwyTLfJv7SUmrgSQbpcRiExQNu6amT4XRSZoLUpAE4yThYX5R9OO3e0FHtFHazjKpPLYC7iWWMbJYmujTm8gku5OkxIJlDCEZRwRG19Bri7Epl4ociJwaeUPnyvr3ASPRP3PaUuqUgXftrlsHGPGGbV1OjIB94N64D8zHvKFcEOCTi0c9cMQ5d8DlR86baRgSMcOZ1NnVaNJmwgHFvJITfaDIGmoBmo67kALAbObZgkJ4cBWA4yGPgtNb7BV56o8yF7pLLR066JKWWOI2bUtSjvJm2OwiPbfbmHTA5R2FxKnS4UXfgnVL8Fpx64j2UA5QKnKuJA4XrBIEENB2zHDs485sFFuXnVO0y06CjoAKykMPgEplS7Rq6bRk9owrQChspTb4NOw9y6Izn9mUjpFeAJhkci6vGnVbiIx1ggFMGTunnxEWVoJ6VHCQud6omKSbBUNFWJc8x5ycIN9c6UR4pMPRveghTrE2ZinwrqjYpJCarBVvbB4fBVWLUOvIo9uRyXDeKfvYKinwpnPC0xSP7yeGde0CfGCRv9H8uQLuwDUBUPMFQsEnXLyE9G0J6qkGFht34vde3yYNREU1HgFyjQvPS5nihWWqxJ1zEeVfgukcyYQkbBOKAQDwPn4efrPhaHzVbV50ZhaLzFEIm6x"), out output);
                    Console.WriteLine(output);
                    udpclient.Close();
                }
            }

            timerPacketSpam.Stop();
        }

        private void buttonToggleSpammer_Click(object sender, EventArgs e)
        {
            packetspammerisopen = !packetspammerisopen;
            if (packetspammerisopen)
            {
                if (!int.TryParse(textBoxMinPort.Text, out packetspammerport))
                {
                    portscannerisopen = false;
                    MessageBox.Show("Port is invalid! Please enter a valid port!");
                }
                else
                {
                    if (packetspammerport > 65535 || packetspammerport < 0)
                    {
                        portscannerisopen = false;
                        MessageBox.Show("Port is invalid! Please enter a valid port!");
                    }
                    else
                    {
                        if (ipisinit)
                        {
                            timerPacketSpam.Start();
                            buttonToggleSpammer.Text = "Stop Spammer";
                        }
                        else
                        {
                            packetspammerisopen = false;
                            MessageBox.Show("IP Address or hostname is invalid! Please enter a valid IP Address or hostname.");
                        }
                    }
                }
            }
            else
            {
                timerPacketSpam.Stop();
                buttonToggleSpammer.Text = "Start Spammer";
            }
        }
    }
}
