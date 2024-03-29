using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem59
{
    public static class Problem59
    {
        public static (long, string) Solve()
        {
            // The cipher file was updated on 5 Feb 2019. This is the old file.
            const string cipherFileName = "Cipher.txt";
            IEnumerable<string> encryptedData = ReadCsvFile(cipherFileName);
            List<int> encyptedList = ConvertToIntList(encryptedData);
            string decryptedData = DecryptData(encyptedList);
            long sum = SumDecryptedAsciiCharacters(decryptedData);

            return (sum, decryptedData);
        }
        
        private static IEnumerable<string> ReadCsvFile(string fileName)
        {
            string wordsString = File.ReadAllText(fileName);
            // Remove trailing newline
            wordsString = wordsString.Substring(0, wordsString.Length - 1);
            List<string> codeArray = wordsString.Split(new[] { ',' }).ToList();

            return codeArray;
        }

        private static List<int> ConvertToIntList(IEnumerable<string> stringList)
        {
            return stringList.Select(item => Convert.ToInt32(item)).ToList();
        }

        private static string DecryptData(IReadOnlyList<int> encyptedList)
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

        private static string DecryptWithPassword(IReadOnlyList<int> encyptedList, string password)
        {
            int length = encyptedList.Count;
            int passwordLength = password.Length;
            List<int> xorList = new();
            List<int> decryptedList = new();
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
            IEnumerable<string> commonWordsList = GetCommonWordsList();
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

        private static IEnumerable<string> GetCommonWordsList()
        {
            List<string> commonWorList = new()
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

        private static long SumDecryptedAsciiCharacters(string decryptedData)
        {
            long sum = 0;

            foreach (char character in decryptedData)
            {
                sum += character;
            }

            return sum;
        }
    }
}