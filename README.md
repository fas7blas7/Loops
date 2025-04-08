⭐ My C# For Loop Coding Tasks

Welcome to my GitHub repository! Here, you'll find various C# coding tasks with structured numbering and detailed solutions. 💻✨

🐜 Introduction

This repository focuses on C# tasks that use `for` loops and conditionals. Each task is isolated, well-named, and crafted to improve understanding of the language fundamentals.

📎 Folder Structure

/For-Loop-Tasks  
│—— /Task1_PowerOfNumber  
│    ├—— PowerOfNumber.cs  
│—— /Task2_MultiplicationTable  
│    ├—— MultiplicationTable.cs  
│—— /Task3_BiggestNumber  
│    ├—— BiggestNumber.cs  
│—— /Task4_VowelSum  
│    ├—— VowelSum.cs  
│—— /Task5_DivisionTo234  
│    ├—— DivisionTo234.cs  
│—— README.md  

🛠️ Setup & Usage

🔧 Prerequisites

- Install .NET SDK (if not already installed)
- Use any C#-compatible editor (e.g., Visual Studio, VS Code)

▶️ Running a Task

```bash
cd Task1_PowerOfNumber
dotnet build
dotnet run

📌 Task List

1️⃣ Power of Number 🧮
Namespace: _1_PowerOfNumber
📌 Description:
Reads two integers and calculates the result of the first raised to the power of the second using a for loop.

📝 Code:

int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 0; i < power; i++)
{
    result *= number;
}
Console.WriteLine(result);

2️⃣ Multiplication Table ✖️
Namespace: _2_MultiplicationTable
📌 Description:
Prints the multiplication table for a given number from 1 to 10.

📝 Code:

int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}

3️⃣ Biggest Number 🏆
Namespace: _3_BiggestNumber
📌 Description:
Reads n integers and prints the largest one.

📝 Code:

namespace _3_BiggestNumber
{
    internal class BiggestNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNumber = int.MinValue;

            for (int i = 1; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}

4️⃣ Vowel Sum 🔤
Namespace: _4_VowelSum
📌 Description:
Reads a sequence of characters and calculates a vowel score where each vowel contributes a specific value.

📝 Code:

namespace _4_VowelSum
{
    internal class VowelSum
    {
        static void Main(string[] args)
        {
            int countOfCharacters = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < countOfCharacters; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                if (currentChar == 'a') sum += 1;
                else if (currentChar == 'e') sum += 2;
                else if (currentChar == 'i') sum += 3;
                else if (currentChar == 'o') sum += 4;
                else if (currentChar == 'u') sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}

5️⃣ Division to 2, 3, and 4 ➗
Namespace: _5_DivisionTo234
📌 Description:
Reads n numbers and calculates the percentage divisible by 2, 3, and 4.

📝 Code:

namespace _5_DivisionTo234
{
    internal class DivisionTo234
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double divisibleBy2 = 0;
            double divisibleBy3 = 0;
            double divisibleBy4 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0) divisibleBy2++;
                if (currentNumber % 3 == 0) divisibleBy3++;
                if (currentNumber % 4 == 0) divisibleBy4++;
            }

            Console.WriteLine($"{(divisibleBy2 / n) * 100:F2}%");
            Console.WriteLine($"{(divisibleBy3 / n) * 100:F2}%");
            Console.WriteLine($"{(divisibleBy4 / n) * 100:F2}%");
        }
    }
}

🎯 Commit Progress Tracker

🚀 Goal: 500 commits in 2025
📅 Current Progress: 357 commits

📊 Progress Bar:

██████████████████████▒▒ 71.4% (357/500)

📌 Milestones: ✅ 100 commits
✅ 200 commits
✅ 300 commits
🔲 400 commits
🔲 500 commits (🎉)
