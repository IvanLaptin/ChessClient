using NetworkLevel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

public class Client : User
{
    public static Client currentClient = new Client();

    public void Connect()
    {
        try
        {
            if (clientSocket != null) return;

            EndPoint addr = new IPEndPoint(IPAddress.Parse("10.6.6.7"), 2017);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            clientSocket.Connect(addr);
            //Console.WriteLine("Connected!");
            ThreadPool.QueueUserWorkItem(ReceiveMessage);
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
    }


}
