using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class FileRead
    {
        private char[] charBuffer = new char[1];
       
        public  void ReadFileWithFixedBuffer(string inputFilePath= @"C:\Personal\Git\codinginterview\ArrayProblems\ArrayProblems\Files\Test.txt")
        {
            //const int MAX_BUFFER = 33554432; //32MB
            const int MAX_BUFFER = 1000;
            byte[] buffer = new byte[MAX_BUFFER];
            int bytesRead;
            StringBuilder currentLine = new StringBuilder();

            using (FileStream fs = File.Open(inputFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                string line;
                bool stop = false;
                var memoryStream = new MemoryStream(buffer);
                var stream = new StreamReader(memoryStream);
                while ((bytesRead = bs.Read(buffer, 0, MAX_BUFFER)) != 0)
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);

                    while (!stream.EndOfStream)
                    {
                        line = ReadLineWithAccumulation(stream, currentLine);

                        if (line != null)
                        {
                            using (StreamWriter file = new StreamWriter(@"C:\Personal\Git\codinginterview\ArrayProblems\ArrayProblems\Files\Test2.txt",true))
                            {
                                file.WriteLine(ReverseWordsInString.GetReversedWordsInsentence(line));
                            }
                        }
                    }
                }
            }

        }

        private  string ReadLineWithAccumulation(StreamReader stream, StringBuilder currentLine)
        {
            while (stream.Read(charBuffer, 0, 1) > 0)
            {
                if (charBuffer[0].Equals('\n'))
                {
                    string result = currentLine.ToString();
                    currentLine.Clear();

                    if (result.Last() == '\r') //remove if newlines are single character
                    {
                        result = result.Substring(0, result.Length - 1);
                    }

                    return result;
                }
                else
                {
                    currentLine.Append(charBuffer[0]);
                }
            }

             return null;  //line not complete yet
        }


    }
}
