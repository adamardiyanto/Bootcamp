﻿using System;
using System.IO;

namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"FileInfo1.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            //Create File
            using (FileStream fs = fileInfo.Open(FileMode.Create, FileAccess.Read))
            {
                // byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!"); //Convert string to byte array
                // fs.Write(data, 0, data.Length); //data, offset, count
            }

            //Display File Info            
            Console.WriteLine("File Created on : " + fileInfo.CreationTime);
            Console.WriteLine("Directory Name : " + fileInfo.DirectoryName);
            Console.WriteLine("Name of File : " + fileInfo.Name);
            Console.WriteLine("Full Name of File : " + fileInfo.FullName);
            Console.WriteLine("Length of File : " + fileInfo.Length);
            Console.WriteLine("Is Readonly : " + fileInfo.IsReadOnly);
            Console.WriteLine("File is Last Accessed on : " + fileInfo.LastAccessTime);

            //Deleting File
            Console.WriteLine("Press small y for delete this file");
            try
            {
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'y')
                {
                    if (fileInfo.Exists)
                    {
                        fileInfo.Delete();
                        Console.WriteLine(filePath + " Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("File doesn't exist");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Press Anykey to Exit...");
            }
            Console.ReadKey();
        }
    }
}