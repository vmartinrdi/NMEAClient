using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace NMEAClient
{
	class Program
	{
		private const int portNum = 10116;

		public static int Main(String[] args)
		{
			//AsynchronousClient.StartClient();
			return 0;
		}

	//    static void Main(string[] args)
	//    {
	//        TcpClient tcpClient = new TcpClient();
	//        try
	//        {
	//            tcpClient.Connect("localhost", portNum);
	//            NetworkStream networkStream = tcpClient.GetStream();

	//            if (networkStream.CanWrite && networkStream.CanRead)
	//            {
	//                string DataToSend = ""; // client id

	//                Byte[] sendBytes = Encoding.ASCII.GetBytes(DataToSend);
	//                networkStream.Write(sendBytes, 0, sendBytes.Length);

	//                // Reads the NetworkStream into a byte buffer.
	//                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
	//                int BytesRead = networkStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);

	//                while (BytesRead > 0)
	//                {
	//                    // Returns the data received from the host to the console.
	//                    string returndata = Encoding.ASCII.GetString(bytes, 0, BytesRead);
	//                    Console.WriteLine("This is what the host returned to you: \r\n{0}", returndata);

	//                    BytesRead = networkStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);
	//                }

	//                networkStream.Close();
	//                tcpClient.Close();
	//            }
	//            else if (!networkStream.CanRead)
	//            {
	//                Console.WriteLine("You can not write data to this stream");
	//                tcpClient.Close();
	//            }
	//            else if (!networkStream.CanWrite)
	//            {
	//                Console.WriteLine("You can not read data from this stream");
	//                tcpClient.Close();
	//            }
	//        }
	//        catch (SocketException)
	//        {
	//            Console.WriteLine("Sever not available!");
	//        }
	//        catch (System.IO.IOException)
	//        {
	//            Console.WriteLine("Sever not available!");
	//        }
	//        catch (Exception e)
	//        {
	//            Console.WriteLine(e.ToString());
	//        }
	//    }
	}
}
