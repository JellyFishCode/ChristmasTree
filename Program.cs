using System;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasTree tree = new ChristmasTree();

            tree.DrawChristmastree(5, true, true);
            tree.DrawTree(4);
        }

        public class ChristmasTree
        {
            private char TreeCharacter = 'X';
            private bool treeStand = false;
            private bool star = true;
            
            public void DrawTree(int height)
            {
                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    Console.Write(new String(' ', height - i - 1));
                    Console.Write(new String(TreeCharacter, i * 2 + 1));
                    Console.Write(new String(' ', height - i - 1));
                    Console.WriteLine();

                }
            }

            public void DrawChristmastree(int height, bool treeStand, bool star)
            {
                Console.WriteLine();

                if (treeStand == true && star == true)
                {
                    Console.Write(new String(' ', height - 1));
                    Console.Write(new String('*', 1));
                    Console.Write(new String(' ', height - 1));
                    Console.WriteLine();

                    for (int i = 0; i < height; i++)
                    {
                        Console.Write(new String(' ', height - i - 1));
                        Console.Write(new String(TreeCharacter, i * 2 + 1));
                        Console.Write(new String(' ', height - i - 1));
                        Console.WriteLine();
                    }

                    Console.Write(new String(' ', height - 1));
                    Console.Write(new String('|', 1));
                    Console.Write(new String(' ', height - 1));
                    Console.WriteLine();

                }
                else
                {
                    for (int i = 0; i < height; i++)
                    {
                        Console.Write(new String(' ', height - i - 1));
                        Console.Write(new String(TreeCharacter, i * 2 + 1));
                        Console.Write(new String(' ', height - i - 1));
                        Console.WriteLine();

                    }
                }
            }
        }
    }
}
