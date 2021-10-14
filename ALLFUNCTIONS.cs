//ALL FUNCTIONS IN ONE FUNCTION

using System;
using EZCode;
using System.IO;
using System.Reflection;
using System.Net;
using System.Net.Sockets;
					
public class Program {
	public static void Main() {
	        //Console Methods
		EZCode.Console.WriteLine("Hello World!");
		EZCode.Console.WriteInt(5);
		EZCode.Console.ReadLine();
		EZCode.Console.ReadKey();
		EZCode.Console.ClearConsole();
		
	        //Math Methods
	        EZCode.Math.Add(int1,int2);
		EZCode.Math.Subtract(int1,int2);
		EZCode.Math.Multiply(int1,int2);
		EZCode.Math.Divide(int1,int2);
		EZCode.Math.Sin(int1);
		EZCode.Math.Cos(int1);
		EZCode.Math.Tan(int1);
		EZCode.Math.Pow(int1);
		EZCode.Math.Round(int1,int2);
		
		//Files Methods
		EZCode.Files.Create("monkey.monke");
		EZCode.Files.Delete("monkey.monke");
		EZCode.Files.Move("monkey.monke",destination);
		EZCode.Files.Copy("monkey.monke",destination);
		EZCode.Files.Open("monkey.monke",FileMode.Open);
		
		//Loop Methods
		EZCode.Loops.FLoopDoFunc(length,functionName);
		EZCode.Loops.FLoopConsoleWriteLine(length,line);
		EZCode.Loops.FLoopWriteInt(length,int1);
		
		//Net Methods
		EZCode.Net.InitalizeClient();
		EZCode.Net.DownloadFile(webClient,link,fileName);
		EZCode.Net.SendSocket(ip,sentString);
		EZCode.Net.ListenForPackets();
		
		//EZCode Specials Coming Soon!
	}
}
