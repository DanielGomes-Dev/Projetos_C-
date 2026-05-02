using System;
using System.Text;
using System.IO;


namespace HTML_Editor
{
    public class Viewer
    {
             public static void Show(string text){
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Modo Visualização");
                Console.WriteLine("-----------");
                Console.WriteLine("-----------");
                Console.WriteLine("-----------");
                Replace(text);
                Console.WriteLine("-----------");
                Console.ReadKey();
                Menu.Show();
            }

            public static void Replace(string text){
                //var strong = new Regex("REGEX");
                Console.WriteLine(text);
                var words = text.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(words[i]);    

                }
            }
    }
}