using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem59
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 59");

            long result = Solve();
            Console.WriteLine($"result = {result}");        // 107359

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static long Solve()
        {
            const string cipherFileName = "Cipher.txt";
            List<string> encryptedData = ReadCsvFile(cipherFileName);
            List<int> encyptedList = ConvertToIntList(encryptedData);
            string decryptedData = DecryptData(encyptedList);
            Console.WriteLine(decryptedData);
            long sumOfDecryptedAsciiCharacters = SumDecryptedAsciiCharacters(decryptedData);

            return sumOfDecryptedAsciiCharacters;
        }
        
        private static List<string> ReadCsvFile(string fileName)
        {
            string wordsString = File.ReadAllText(fileName);
            // Remove trailing newline
            wordsString = wordsString.Substring(0, wordsString.Length - 1);
            List<string> codeArray = wordsString.Split(new[] { ',' }).ToList();

            return codeArray;
        }

        private static List<int> ConvertToIntList(List<string> stringList)
        {
            List<int> intList = new List<int>();

            foreach (string item in stringList)
            {
                int code = Convert.ToInt32(item);
                intList.Add(code);
            }

            return intList;
        }

        private static long SumDecryptedAsciiCharacters(string decryptedData)
        {
            long sum = 0;

            foreach (char character in decryptedData)
            {
                sum += character;
            }

            return sum;
        }

        private static List<string> GetCommonWordsList()
        {
            List<string> commonWorList = new List<string>
            {
                "the",
                "of",
                "and",
                "a",
                "to",
                "in",
                "is",
                "you",
                "that",
                "it",
                "he",
                "was",
                "for",
                "on",
                "are",
                "as",
                "with"
            };

            return commonWorList;
        }

        private static string DecryptData(List<int> encyptedList)
        {
            int maxRank = 0;
            string bestDecryptedDataMatch = "";

            for (char key1 = 'a'; key1 <= 'z'; key1++)
            {
                for (char key2 = 'a'; key2 <= 'z'; key2++)
                {
                    for (char key3 = 'a'; key3 <= 'z'; key3++)
                    {
                        string password = $"{key1}{key2}{key3}";
                        string decryptedData = DecryptWithPassword(encyptedList, password);
                        int rank = IsValidDecryption(decryptedData);

                        if (rank > maxRank)
                        {
                            maxRank = rank;
                            bestDecryptedDataMatch = decryptedData;
                        }
                    }
                }
            }

            return bestDecryptedDataMatch;
        }

        private static string DecryptWithPassword(List<int> encyptedList, string password)
        {
            int length = encyptedList.Count;
            int passwordLength = password.Length;
            List<int> xorList = new List<int>();
            List<int> decryptedList = new List<int>();
            string decryptedData = "";

            for (int n = 0; n < length; n++)
            {
                int index = n % passwordLength;
                char charKey = password[index];
                int intKey = Convert.ToInt32(charKey);
                xorList.Add(intKey);
            }

            for (int n = 0; n < length; n++)
            {
                int decryptedValue = encyptedList[n] ^ xorList[n];
                decryptedList.Add(decryptedValue);
            }

            for (int n = 0; n < length; n++)
            {
                char decryptedChar = (char) decryptedList[n];
                decryptedData += decryptedChar;
            }

            return decryptedData;
        }

        private static int IsValidDecryption(string decryptedData)
        {
            List<string> commonWordsList = GetCommonWordsList();
            int commonWordMatches = 0;
            string lowerDecryptedData = decryptedData.ToLower();

            foreach (string word in commonWordsList)
            {
                if (lowerDecryptedData.Contains(word))
                {
                    commonWordMatches++;
                }
            }

            return commonWordMatches;
        }
    }
}
