﻿namespace TestTask
{
    /// <summary>
    /// Статистика вхождения буквы/пары букв
    /// </summary>
    public class LetterStats
    {
        /// <summary>
        /// Буква/Пара букв для учёта статистики.
        /// </summary>
        public string Letter { get; set; }

        /// <summary>
        /// Кол-во вхождений буквы/пары.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public LetterStats(string letter, int count)
        {
            this.Letter = letter;
            this.Count = count;
        }
    }
}
