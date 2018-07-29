using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem18
{
    class Node
    {
        public Node()
        {

        }

        public Node(int value, int leftvalue, int rightValue)
        {
            Value = value;
            LeftValue = leftvalue;
            RightValue = rightValue;
        }

        public int Value { get; set; }
        public int LeftValue { get; set; }
        public int RightValue { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Problem 18");

            Node root = LoadBinaryTree();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static Node LoadBinaryTree()
        {
            string treeString =
                                            "75 " +
                                          "95  64 " +
                                        "17  47  82 " +
                                      "18  35  87  10 " +
                                    "20  04  82  47  65 " +
                                  "19  01  23  75  03  34 " +
                                "88  02  77  73  07  63  67 " +
                              "99  65  04  28  06  16  70  92 " +
                            "41  41  26  56  83  40  80  70  33 " +
                          "41  48  72  33  47  32  37  16  94  29 " +
                        "53  71  44  65  25  43  91  52  97  51  14 " +
                      "70  11  33  28  77  73  17  78  39  68  17  57 " +
                    "91  71  52  38  17  14  91  43  58  50  27  29  48 " +
                  "63  66  04  68  89  53  67  30  73  16  69  87  40  31 " +
                "04  62  98  27  23  09  70  98  73  93  38  53  60  04  23";

            string[] treeArray = treeString.Split(new char[] { ' ' });
            List<int> treeList = new List<int>();

            foreach (string valueString in treeArray)
            {
                int value = Convert.ToInt32(valueString);
                treeList.Add(value);
            }

            const int treeDepth = 15;
            Node root = new Node();

            #region old
            Node current = root;
            int skip = 0;
            int take;

            for (int n = 1; n <= treeDepth; n++)
            {
                take = treeDepth;
                var list = treeList.Skip(skip).Take(take);
                //CreateChildNodes(current);


                skip += take;
            }
            #endregion

            //GetNext(depth, n)

            root.Value = 75;
            CreateChildNodes(root, treeList, treeDepth);


            return new Node(1, 1, 1);
        }

        private static void CreateChildNodes(Node current, List<int> treeList, int depth)
        {
            
        }
    }
}
