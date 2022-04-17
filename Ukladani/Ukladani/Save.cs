using System;

namespace Ukladani
{
    public class Save
    {
        //string File
        
        private string ReadFromFile(string fileName)
        {
            string path = GetFilePath(fileName);
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string jsonData = reader.ReadToEnd();
                    return jsonData;
                }
            }else
            {
                Console.WriteLine("!File not found!");
            }

            return "";
        }
        private string GetFilePath(string fileName)
        {
            return  "C:/Users/filip/Documents/Random-Code/random-code/Ukladani/Ukladani" + "/" + fileName;
        }
    }
}