using System;

internal class Solution1
    {
        static void Main()
        {
            
            string[] wordList = { "кот", "собака", "унитаз", "влад" };
            Random random = new Random();
            string wordSelect = wordList[random.Next(0,4)];
            string word = wordSelect;
            int count = 6, pob = 0;
            List<string> usedChar = new List<string>();
            char[] stars = new string('*', wordSelect.Length).ToCharArray();
            Console.WriteLine("Добро пожаловать в игру Виселица!");
            Console.WriteLine("У вас есть 6 попыток угадать слово из {0} букв", wordSelect.Length);
            Console.WriteLine("Загаданное слово " + string.Join("", stars));
            while (true)
            {
                if (count == 0)
                {
                    Console.WriteLine("Вы проиграли!");
                    Console.ReadKey();
                    break;
                }
                if (pob == wordSelect.Length)
                {
                    Console.WriteLine("Вы выиграли!");
                    Console.ReadKey();
                    break;
                }
                Console.Write("Введите букву: ");
                string ch = Console.ReadLine().ToLower();
                if (wordSelect.Contains(ch[0]) && !usedChar.Contains(ch[0].ToString()))
                {
                    for (int i = 0; i < wordSelect.Length; i++)
                        if (wordSelect[i] == ch[0])
                        {
                            stars[i] = ch[0];
                            ++pob;
                        }
                    Console.WriteLine("Буква -{0}- есть в этом слове.", ch[0]);
                    Console.WriteLine("Загаданное слово " + string.Join("", stars));
                    usedChar.Add(ch[0].ToString());
                }
                else if (!wordSelect.Contains(ch[0]) && !usedChar.Contains(ch[0].ToString()))
                {
                    count--;
                    Console.WriteLine("Буква -{0}-  НЕТ в этом слове. У вас осталось: {1} попыток", ch[0], count);
                    
                }
                
            }
        }
    }
