using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace FileExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //TASK 1
            /*
            string filePath = null;  // sonrakı tapşırıqlarda da  istifadə etmık üçün yazdım.
            string fileName = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("The file already exists. Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Create(filePath).Close();
                        Console.WriteLine($"File '{fileName}' has been created.");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            } while (true);
           */





            //TASK 2
            /*
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            do
            {
                Console.Write("Write the name of the file you want to delete :   ");
                string fileToDelete = Console.ReadLine();
                string filePath = $@"C:\Users\Senan\Desktop\{fileToDelete}";

                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist . Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Delete(filePath);
                        Console.WriteLine($"The file '{fileToDelete}' deleted successfully.");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }

            } while (true);
            */





            //TASK 3
            /*
            string filePath = null;
            string fileName = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                try
                {
                    File.Create(filePath).Close();
                    Console.WriteLine($"File '{fileName}' has been created.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            } while (true);
            */





            //TASK 4
            /*
           string filePath = null;
           string fileName = null;
           do
           {
               Console.Write("Write your file name: ");
               fileName = Console.ReadLine();
               filePath = $@"C:\Users\Senan\Desktop\{fileName}";

               if (File.Exists(filePath))
               {
                   Console.WriteLine("The file already exists. Please choose a different name.");
               }
               else
               {
                   try
                   {
                       File.Create(filePath).Close();
                       Console.WriteLine($"File '{fileName}' has been created.");
                       Console.WriteLine("-------------------------------------------");
                       Console.WriteLine("Add some text: ");
                       string[] text = { Console.ReadLine() };
                       File.WriteAllLines(filePath, text);
                       Console.WriteLine("-------------------------------------------");
                       Console.WriteLine("Text added.");
                       break;
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine($"An error occurred: {ex.Message}");
                   }
               }
           } while (true);
          */





            //TASK 5
            /*
           string filePath = null;
           string fileName = null;
           do
           {
               Console.Write("Write your file name: ");
               fileName = Console.ReadLine();
               filePath = $@"C:\Users\Senan\Desktop\{fileName}";

               if (File.Exists(filePath))
               {
                   Console.WriteLine("The file already exists. Please choose a different name.");
               }
               else
               {
                   try
                   {
                       File.Create(filePath).Close();
                       Console.WriteLine($"File '{fileName}' has been created.");
                       Console.WriteLine("-------------------------------------------");
                       Console.WriteLine("Add some text: ");
                       string text = Console.ReadLine();
                       File.WriteAllText(filePath, text);
                       Console.WriteLine("-------------------------------------------");
                       Console.WriteLine("Text added.");
                       Console.WriteLine("--------------------------------------------");
                       Console.WriteLine($"Here is the content of the file '{fileName}' : ");
                       string context = File.ReadAllText(filePath);
                       Console.WriteLine(context);
                       break;
                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine($"An error occurred: {ex.Message}");
                   }
               }
           } while (true);
           */





            //TASK 6 
            /*
           string filePath = null;
           string fileName = null;
           do
           {
               Console.Write("Write your file name: ");
               fileName = Console.ReadLine();
               filePath = $@"C:\Users\Senan\Desktop\{fileName}";

               if (File.Exists(filePath))
               {
                   Console.WriteLine("The file already exists. Please choose a different name.");
               }
               else
               {
                   try
                   {
                       File.Create(filePath).Close();
                       Console.WriteLine($"File '{fileName}' has been created.");
                       Console.WriteLine("--------------------------------------------");

                       Console.Write("Input number of lines to write in the file : ");

                       int line = int.Parse(Console.ReadLine());
                       string[] context = new string[line];

                       Console.WriteLine($"Input {line} strings below :");

                       for (int i = 1; i <= line; i++)
                       {
                           Console.Write($"Input line {i} : ");
                           context[i - 1] = Console.ReadLine();
                       }
                       File.WriteAllLines(filePath, context);
                       Console.WriteLine($"Here is the content of the file {fileName} : ");

                       string[] fileContent = File.ReadAllLines(filePath);
                       for (int i = 0; i < fileContent.Length; i++)
                       {
                           Console.WriteLine($"This is {i + 1} line:{fileContent[i]}");
                       }
                       break;

                   }
                   catch (Exception ex)
                   {
                       Console.WriteLine($"An error occurred: {ex.Message}");
                   }
               }
           } while (true);
           */






            //TASK 7
            /*
            do
            {
                Console.Write("Write your file name: ");
                string fileName = Console.ReadLine();
                string filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("The file already exists. Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Create(filePath).Close();
                        Console.WriteLine($"File '{fileName}' has been created.");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Input the string to ignore the line : ");
                        string ignore = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Input number of lines to write in the file : ");
                        int line = int.Parse(Console.ReadLine());
                        Console.WriteLine("--------------------------------------------");

                       
                        string[] context = new string[line];
                        Console.WriteLine($"Input {line} strings below :");

                        for (int i = 1; i <= line; i++)
                        {
                            Console.Write($"Input line {i} : ");
                            context[i - 1] = Console.ReadLine();
                        }
                        string[] filteredContext = null;
                        if (context.Any(lineText => lineText.Contains(ignore)))
                        {
                            Console.WriteLine($"The line have ignored which contain the string '{ignore}'");
                            filteredContext = context.Where(lineText => !lineText.Contains(ignore)).ToArray();
                            File.WriteAllLines(filePath, filteredContext);
                        }
                        else
                        {
                            File.WriteAllLines(filePath, context);
                        }
                       
                        Console.WriteLine($"Here is the content of the file {fileName} : ");
                        Console.WriteLine("--------------------------------------------");

                        string[] fileContent = File.ReadAllLines(filePath);
                        for (int i = 0; i < fileContent.Length; i++)
                        {
                            Console.WriteLine($"This is {i + 1} line:{fileContent[i]}");
                        }
                        break;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            } while (true);
           */





            //TASK 8
            /*
            string fileName = null;
            string filePath = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                try
                {
                    File.Create(filePath).Close();
                    Console.WriteLine($"File '{fileName}' has been created.");                  
                    AddContent(filePath);                
                    ReadContent(filePath);
                    Console.WriteLine("--------------------------------------------");
                    Console.Write("To append some text to an existing file:");
                    string textToAppend=Console.ReadLine();
                    AppendContent(filePath, textToAppend);                 
                    ReadContent(filePath);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            } while (true);

            static void ReadContent(string filePath)
            {
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (string line in fileContent)
                {
                    Console.WriteLine(line);
                }
            }
            static void AddContent(string filePath)
            {
                Console.WriteLine("--------------------------------------------");
                Console.Write(" Include the content of the context: ");
                string content = Console.ReadLine();
                File.AppendAllText(filePath, content + "\r\n");
            }
            static void AppendContent(string filePath, string textToAppend)
            {
                File.AppendAllText(filePath, textToAppend + "\r\n");
                Console.WriteLine("Text appended successfully.");
                Console.WriteLine($"Here is the content of the file after appending the text : ");
                Console.WriteLine("--------------------------------------------");
            }
            */



            //TASK 9 
            /*
            string fileName = null;
            string filePath = null;

            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                try
                {
                    
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        Console.WriteLine($"File '{fileName}' has been created.");

                        Console.WriteLine("Enter your text. To finish entering, leave a line blank and press Enter:");
                        string line;
                        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
                        {
                            writer.WriteLine(line);
                        }
                    }

                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Create a file and copy it into the same directory with another name.");
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.Write("Write the destination file name: ");
                    string destFileName = Console.ReadLine();
                    string destFilePath = $@"C:\Users\Senan\Desktop\{destFileName}";

                   
                    File.Copy(filePath, destFilePath);
                    Console.WriteLine($"The file {fileName} has been successfully copied to {destFileName} in the same directory.");
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("The contents of the copied file are displayed below:");

                    Console.WriteLine("---------------------------------------");
                    string[] fileContent = File.ReadAllLines(destFilePath);
                    foreach (var content in fileContent)
                    {
                        Console.WriteLine(content);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            } while (true);
            */





            //TASK 10 
            /*
            string fileName = null;
            string filePath = null;

            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                try
                {
                    File.Create(filePath).Close();
                    Console.WriteLine($"File '{fileName}' has been created.");

                    Console.WriteLine("Enter your text .To finish entering, leave a line blank and press Enter:");
                    var lines = new List<string>();
                    string line;
                    int countLine = 0;
                    while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
                    {
                        lines.Add(line);
                        countLine++;
                    }
                    File.WriteAllLines(fileName, lines);
                    Console.WriteLine("---------------------------------------");     
                    Console.WriteLine("Create a file and move it into the same directory with another name.");
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.Write("Write your file name: ");
                    string  destfileName = Console.ReadLine();
                    filePath = $@"C:\Users\Senan\Desktop\{fileName}";
                    File.Move(fileName, destfileName);
                    Console.WriteLine($"The file {fileName} successfully moved to the name '{destfileName}' in the same directory.");
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("The contents of the file are displayed below:");
                 
                    Console.WriteLine("---------------------------------------");
                    string[] fileContent = File.ReadAllLines(destfileName);
                    foreach (var content in fileContent)
                    {
                        Console.WriteLine(content);
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            } while (true);
            */





            //TASK 11
            /*
            string filePath = null;
            string fileName = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("The file already exists. Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Create(filePath).Close();
                        Console.WriteLine($"File '{fileName}' has been created.");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Input number of lines to write in the file : ");

                        int line = int.Parse(Console.ReadLine());
                        string[] context = new string[line];

                        Console.WriteLine($"Input {line} strings below :");

                        for (int i = 1; i <= line; i++)
                        {
                            Console.Write($"Input line {i} : ");
                            context[i - 1] = Console.ReadLine();
                        }
                        File.WriteAllLines(filePath, context);


                        Console.WriteLine($"The content of the last line of the file {fileName} is :   ");

                        string[] fileContent = File.ReadAllLines(filePath);
                        Console.WriteLine(fileContent[0]);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            } while (true);
            */






            //TASK 12 
            /*
            string filePath = null;
            string fileName = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("The file already exists. Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Create(filePath).Close();
                        Console.WriteLine($"File '{fileName}' has been created.");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Input number of lines to write in the file : ");

                        int line = int.Parse(Console.ReadLine());
                        string[] context = new string[line];

                        Console.WriteLine($"Input {line} strings below :");

                        for (int i = 1; i <= line; i++)
                        {
                            Console.Write($"Input line {i} : ");
                            context[i - 1] = Console.ReadLine();
                        }
                        File.WriteAllLines(filePath, context);


                        Console.WriteLine($"The content of the last line of the file {fileName} is :   ");

                        string[] fileContent = File.ReadAllLines(filePath);
                        Console.WriteLine(fileContent[fileContent.Length-1]);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            } while (true);
            */





            //TASK 13 
            /*
            string filePath = null;
            string fileName = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("The file already exists. Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Create(filePath).Close();
                        Console.WriteLine($"File '{fileName}' has been created.");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Input number of lines to write in the file : ");

                        int line = int.Parse(Console.ReadLine());
                        string[] context = new string[line];

                        Console.WriteLine($"Input {line} strings below :");

                        for (int i = 1; i <= line; i++)
                        {
                            Console.Write($"Input line {i} : ");
                            context[i - 1] = Console.ReadLine();
                        }
                        File.WriteAllLines(filePath, context);

                        Console.Write("Input which line you want to display : ");
                        int lineNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine($"The content of the line {lineNumber} of the file {fileName} is :   ");

                        string[] fileContent = File.ReadAllLines(filePath);
                        if (lineNumber >= 1 && lineNumber <= context.Length)
                        {
                            Console.WriteLine($"This is line {lineNumber}: {context[lineNumber - 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid line number. Please choose a valid line.");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            } while (true);
            */






            //TASK 14 
            /*
            string filePath = null;
            string fileName = null;
            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                if (File.Exists(filePath))
                {
                    Console.WriteLine("The file already exists. Please choose a different name.");
                }
                else
                {
                    try
                    {
                        File.Create(filePath).Close();
                        Console.WriteLine($"File '{fileName}' has been created.");
                        Console.WriteLine("--------------------------------------------");

                        Console.Write("Input number of lines to write in the file : ");

                        int line = int.Parse(Console.ReadLine());
                        string[] context = new string[line];

                        Console.WriteLine($"Input {line} strings below :");

                        for (int i = 1; i <= line; i++)
                        {
                            Console.Write($"Input line {i} : ");
                            context[i - 1] = Console.ReadLine();
                        }
                        File.WriteAllLines(filePath, context);

                        Console.Write("Input last how many numbers of lines you want to display : ");
                        int lines = int.Parse(Console.ReadLine());

                        Console.WriteLine($"The content of the last {lines} lines of the file {fileName} is :   ");
                        
                        string[] fileContent = File.ReadAllLines(filePath);
                        for (int i = lines-1; i < fileContent.Length; i++)
                        {
                            Console.WriteLine($"This is {i + 1} line:{fileContent[i]}");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            } while (true);
            */





            //TASK 15 
            /*
            string fileName = null;
            string filePath = null;

            do
            {
                Console.Write("Write your file name: ");
                fileName = Console.ReadLine();
                filePath = $@"C:\Users\Senan\Desktop\{fileName}";

                try
                {
                    File.Create(filePath).Close();
                    Console.WriteLine($"File '{fileName}' has been created.");
                    
                    Console.WriteLine("Enter your text .To finish entering, leave a line blank and press Enter:");
                    var lines = new List<string>();
                    string line;
                    int countLine= 0;
                    while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
                    {
                        lines.Add(line);
                        countLine++;
                    }
                    File.WriteAllLines(fileName, lines);
                    Console.WriteLine("The contents of the file are displayed below:");
                    Console.WriteLine("---------------------------------------");
                    string[] fileContent = File.ReadAllLines(fileName);

                    foreach (string fileLine in fileContent)
                    {
                        Console.WriteLine(fileLine);
                    }
                    Console.WriteLine($"The number of lines in  the file '{fileName}' is : {countLine}  ");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            } while (true);
            */








        }





    }

    
}

    