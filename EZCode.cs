using System;
using System.IO;
using System.Reflection
using EZCode;
using System.Net;
using System.Net.Sockets;

//the namespace is called EZCode.
//created by ImTrxsh.

namespace EZCode {
	public class Console {
		public static void WriteLine(string line) {
			try {
				Console.WriteLine(line);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void WriteInt(int output) {
			try {
				System.Console.Write(output);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void ReadLine() {
			try {
				Console.ReadLine();
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void ClearConsole() {
			try {
				System.Console.Clear();
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
	}
	public class Net {
		public static WebClient InitalizeClient() {
			WebClient client = new WebClient();
			
			//this initalizes the client and returns it as a value
			EZCode.Console.WriteLine("WebClient initilized.");
			return client;
		}
		public static void DownloadFile(WebClient webclient, string address, string fileName) {
			try {
				webclient.DownloadFile(address, fileName);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		} 
		public static void SendSocket(string ip, string sentString) {
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			System.Net.IPAddress ipAddr = System.Net.IPAddress.Parse(ip);
            System.Net.IPEndPoint remoteEP = new IPEndPoint(ipAddr, 3456);
            socket.Connect(remoteEP);
			
			byte[] byData = System.Text.Encoding.ASCII.GetBytes(sentString);
            socket.Send(byData);
		}
		public static void ListenForPackets() {
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			
			byte[] buffer = new byte[1024];
            int iRx = socket.Receive(buffer);
            char[] chars = new char[iRx];

            System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
            int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
            System.String recv = new System.String(chars);;
			
			bool recievedPacket = false;
			
			while(true) {
				if(recv.Length != 0 && recievedPacket == false) {
					EZCode.Console.WriteLine(recv);
					recievedPacket = true;
				}
			}
		}
	}
	public class Math {
		public static int Add(int input, int input2) {
			return input + input2;
		}
		public static int Subtract(int input, int input2) {
			return input - input2;
		}
		public static int Multiply(int input, int input2) {
			return input * input2;
		}
		public static int Divide(int input, int input2) {
			return input / input2;
		}
		public static int Abs(int input) {
			try {
				Math.Abs(input);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
			return input;
		}
		public static int Sin(int input) {
			try {
				Math.Sin(input);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
			return input;
		}
		public static int Cos(int input) {
			try {
				Math.Cos(input);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
			return input;
		}
		public static int Tan(int input) {
			try {
				Math.Tan(input);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
			return input;
		}
		public static int Pow(int input) {
		    try {
				Math.Pow(input);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
			return input;
		}
		public static void Round(int input, int input2) {
			try{
				Math.Round(input, input2);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		} 
	}
    public class Files {
    	public static void Create(string file) {
			try {
				if(File.Exists(file))
					Console.WriteLine("File Already Exists!");
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void Delete(string file) {
			try {
				File.Delete(file);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void Copy(string file, string destination) {
			try {
				File.Copy(file,destination);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void Move(string originalPath, string destination) {
			try {
				File.Move(originalPath, destination);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void Open(string file) {
			try {
				File.Open(file, FileMode.Open);
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
	  public class Loops {
		public static void FLoopDoFunc(int length, string function) {
			try {
				for(int i = 0; i < length; i++) {
                    MethodInfo method = function.GetType().GetMethod(function);
                    method.Invoke(function, null);
				}
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void FLoopConsoleWriteLine(int length, string line) {
			try {
				for(int i = 0; i < length; i++) {
					EZCode.Console.WriteLine(line);
				}
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
		public static void FLoopDoWriteInt(int length, int interger) {
			try {
				for(int i = 0; i< length; i++) {
					EZCode.Console.WriteInt(interger);
				}
			}catch(Exception e) {
				Console.WriteLine("Error Occured! Printing Stack Trace:" + e.StackTrace);
			}
		}
	}
	public class Special {
		//coming soon !
	}
    }
}
