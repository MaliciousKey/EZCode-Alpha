using System;
using System.IO;

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
	public class Math {
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
    }
}