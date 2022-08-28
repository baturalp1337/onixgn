using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class client
{
    #region UDP
    public static bool udpconnect(UdpClient udpclient, string addy, int port, bool autoclose, out string output)
    {
        try
        {
            udpclient.Connect(addy, port);
            if (udpclient.Client.Connected)
            {
                if (autoclose) udpclient.Close();

                output = "Succesfully connected to Address:" + addy.ToString() + " Port:" + port.ToString() + ".";
                return true;
            }
            else
            {
                udpclient.Close();
                output = "Connection to Address:" + addy.ToString() + " Port:" + port.ToString() + " is failed.";
                return false;
            }
        }
        catch (Exception ex)
        {
            output = ex.Message;
            return false;
        }
    }
    public static bool udpsend(UdpClient udpclient, byte[] data, out string output)
    {
        try
        {
            udpclient.Send(data, data.Length);
            udpclient.AllowNatTraversal(true);
            udpclient.DontFragment = true;

            output = "Data sended!";
            return true;
        }
        catch (Exception ex)
        {
            output = ex.Message;
            return false;
        }  
    }
    #endregion
    #region TCP
    public static bool tcpconnect(TcpClient tcpclient, string addy, int port, bool autoclose, out string output)
    {
        try
        {
            tcpclient.Connect(addy, port);
            if (tcpclient.Connected)
            {
                if (autoclose) tcpclient.Close();

                output = "Succesfully connected to Address:" + addy.ToString() + " Port:" + port.ToString() + ".";
                return true;
            }
            else
            {
                tcpclient.Close();
                output = "Connection to Address:" + addy.ToString() + " Port:" + port.ToString() + " is failed.";
                return false;
            }
        }
        catch (Exception ex)
        {
            output = ex.Message;
            return false;
        }
    }
    public static bool tcpsend(TcpClient tcpclient, byte[] data, out string output)
    {
        try
        {
            NetworkStream ns = tcpclient.GetStream();
            ns.Write(data, 0, data.Length);
            output = "Data sended!";
            return true;
        }
        catch (Exception ex)
        {
            output = ex.Message;
            return false;
        }
    }  
    #endregion
}