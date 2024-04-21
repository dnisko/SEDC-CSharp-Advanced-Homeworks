namespace Class09_Homework
{
    internal class Program
    {
        #region Tasks

        /*
         Task 1
           
               Create a folder named "Files".
               Create a file name "names.txt"
           
         Task 2
         
             Read the file created in the previous task named "names.txt"
             Ask the user to enter some names and save these names in the file that we previously created.
         
         Task 3
         
             Read the file created in the previous task name "names.txt"
             Go through the file content and filter out all the names that start with A. If there are any names create a new file named "namesStartingWith_A.txt"
             that will contain the filtered content and if there are no names that start with A do nothing.
             Do this for all the letters in the alphabet.
         
         Task 4
         
             Redo Task 3 but if the file already exists add the new names in the file and keep the already existing names.
         
         Task 5
         
             Create a folder called Exercise
             Create a txt file in it called calculations
             Create a method that calculates 2 numbers and returns a string in the format: num1 + num2 = result ( Ex: 2 + 3 = 5 )
             Ask the user to enter 2 numbers, call the calculate method and give the result
             After the result is written in the console it should also be written in the calculations.txt file with a time stamp next to it
             Call the console 3 times and write 3 results in the txt file
           
         */

        #endregion
        static void Main(string[] args)
        {
            #region Task01
            /*
             Task 1
                Create a folder named "Files".
                Create a file name "names.txt"
            */
            string folderPath = @"Files";
            string filePath = $@"{folderPath}\names.txt";
            //string namesStartingWith_A = $@"{folderPath}\namesStartingWith_A.txt";
            FileStream file;

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                file = File.Create(filePath);
                file.Close();
            }
            #endregion

            #region Task02
            /*
             Task 2
                Read the file created in the previous task named "names.txt"
                Ask the user to enter some names and save these names in the file that we previously created.
            */

            using (var sr = new StreamReader(filePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            //add the names in a list for easier data manipulation. I could add them in a list after reading the file in Task03 also.
            var namesFromConsole = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter some names:");
                namesFromConsole.Add(Console.ReadLine()!); //intellisense suggested ! after ReadLine() for possible null reference?
                Console.WriteLine("Do you want to enter another one? (y/n)");
                if (Console.ReadLine()!.ToLower() == "y")
                {
                    continue;
                }
                break;
            }

            using (var sw = new StreamWriter(filePath))
            {
                foreach (var name in namesFromConsole)
                {
                    sw.WriteLine(name);
                }
            }
            #endregion

            #region Task03
            /*
             Task 3
                Read the file created in the previous task name "names.txt"
                Go through the file content and filter out all the names that start with A. If there are any names create a new file named "namesStartingWith_A.txt"
                that will contain the filtered content and if there are no names that start with A do nothing.
                Do this for all the letters in the alphabet.
            */

            using (var sr = new StreamReader(filePath))
            {
                Console.WriteLine("\nNames to add in files:");
                Console.WriteLine(sr.ReadToEnd());

                //string nameForFile = $@"{folderPath}\namesStartingWith_";
                for (char letter = 'a'; letter < 'z'; letter++)
                {
                    //var nameWithFileLetter = nameForFile + letter;
                    var nameWithFileLetter = $@"{folderPath}\namesStartingWith_{letter.ToString().ToUpper()}.txt";
                    var tempList = namesFromConsole.Where(x => x.ToLower().StartsWith(letter)).ToList();
                    if (tempList.Count == 0) continue;
                    if (!File.Exists(nameWithFileLetter))
                    {
                        file = File.Create(nameWithFileLetter);
                        file.Close();
                    }

                    foreach (var name in tempList)
                    {
                        //using (var sw = new StreamWriter(nameWithFileLetter, true))
                        //{
                        //    sw.WriteLine(name);
                        //}
                        var sw = new StreamWriter(nameWithFileLetter, true);
                        sw.WriteLine(name);
                    }
                }
            }
            #endregion

            #region Task04
            /*
             Task 4
                 Redo Task 3 but if the file already exists add the new names in the file and keep the already existing names.
            */

            //done in Task03 with if statement and append: true in StreamWriter
            Console.WriteLine($"End of reading {filePath}\n");
            #endregion

            #region Task05
            /*
             Task 05
                Create a folder called Exercise
                Create a txt file in it called calculations
                Create a method that calculates 2 numbers and returns a string in the format: num1 + num2 = result ( Ex: 2 + 3 = 5 )
                Ask the user to enter 2 numbers, call the calculate method and give the result
                After the result is written in the console it should also be written in the calculations.txt file with a time stamp next to it
                Call the console 3 times and write 3 results in the txt file
            */

            const string folderPathTask5 = @"Exercise";
            string filePathTask5 = $@"{folderPathTask5}\calculations.txt";

            if (!Directory.Exists(folderPathTask5))
            {
                Directory.CreateDirectory(folderPathTask5);
            }

            if (!File.Exists(filePathTask5))
            {
                file = File.Create(filePathTask5);
                file.Close();
            }

            var times = 0;
            Console.WriteLine("Enter 2 numbers.");

            while (times < 3)
            {
                int num1, num2;
                while (true)
                {
                    Console.WriteLine("Enter number 1: ");
                    if (!int.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Wrong input.");
                        continue;
                    }

                    while (true)
                    {
                        Console.WriteLine("Enter number 2: ");
                        if (!int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Wrong input.");
                            continue;
                        }

                        break;
                    }

                    break;
                }

                using (var sw = new StreamWriter(filePathTask5, true))
                {
                    string result = Sum(num1, num2);
                    Console.WriteLine(result);
                    sw.WriteLine($"[{DateTime.Now}] {num1} + {num2} = {result}");
                }
                times++;
            }

            Console.WriteLine($"Reading the file {filePathTask5}");
            using (var sr = new StreamReader(filePathTask5))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            //if we want to delete the file, so there will be always 3 lines of result
            File.Delete(filePathTask5);
            #endregion
        }

        public static string Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum.ToString();
        }
    }
}
