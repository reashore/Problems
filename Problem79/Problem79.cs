using System.Collections.Generic;
using System.IO;
using Common;

namespace Problem79
{
    public static class Problem79
    {
        public static string Solve()
        {
            List<string> passcodeList = ReadPasscodes();
            List<int> digitList = GetDigitsFromPasscodes(passcodeList); // 31968027
            LinkedList<int> passwordLinkedList = new LinkedList<int>();

            foreach (int digit in digitList)
            {
                passwordLinkedList.AddLast(digit);
            }

            while (true)
            {
                bool passwordChanged = false;
                
                foreach (string passcode in passcodeList)
                {
                    passwordChanged = passwordLinkedList.ReorderPasswordToMatchPasscode(passcode);

                    if (passwordChanged)
                    {
                        break;
                    }
                }

                if (!passwordChanged)
                {
                    break;
                }
            }

            string password = passwordLinkedList.GetString();

            return password;
        }

        private static List<string> ReadPasscodes()
        {
            const string fileName = "Passcodes.txt";
            string[] passcodesArray = File.ReadAllLines(fileName);
            List<string> passcodeList = new List<string>(passcodesArray);

            return passcodeList;
        }

        private static List<int> GetDigitsFromPasscodes(List<string> passcodeList)
        {
            List<int> digitList = new List<int>();

            foreach (string passcode in passcodeList)
            {
                List<int> passcodeDigitList = Utilities.ConvertNumericStringToList(passcode);

                foreach (int digit in passcodeDigitList)
                {
                    if (!digitList.Contains(digit))
                    {
                        digitList.Add(digit);
                    }
                }
            }

            return digitList;
        }
    }
}