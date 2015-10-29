using System;

namespace SlavaBirthDay
{
    class Program
    {
        private const bool HasGirlFriend = false;
        private const bool HasOwnHouse = false;
        private const bool HasGoodHealth = true;
        private const bool HasFriends = true;
        private const bool HasLifeGoals = true;
        private const bool IsPositivePerson = true;

        static void Main()
        {
            if (DateTime.Now.Date.Equals(new DateTime(2015, 10, 29)))
            {
                Console.Write("Привет имениннеГ. Хочу поздравить тебя с Днем Рождения! ");
                Console.Write("Желаю тебе ");

                if (HasGoodHealth)
                {
                    Console.Write("богатырского здоровья, ");
                }

                if (IsPositivePerson)
                {
                    Console.Write("море счастья, ");
                }

                if (!HasOwnHouse)
                {
                    Console.Write("мешок денег, ");
                }

                if (HasLifeGoals)
                {
                    Console.Write("и успехов во всех начинаниях. ");
                }

                if (!HasGirlFriend)
                {
                    Console.Write("Пусть тебя окружают прекрасные женщины, ");
                }

                if (HasFriends)
                {
                    Console.Write("верные товарищи и просто хорошие люди. ");
                }

                Console.WriteLine("С ДНЮХОЙ!");
            }

            Console.ReadKey();
        }
    }
}
