using System;
using Домашнее_задание_9.Classes;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*На шоу Большие гонки собираются 4 команды из разных стран. В команде по 15 человек. Всего за одну игру команда
            проходит по 6 испытаний (6 разных игр). Будет неинтересно, если каждый раз игры будут одинаковыми, поэтому каждый раз
            игры разные. Главный организатор, Оливье Ганьян, добавляет новые игры. Необходимо правильно организовать 
            классы, чтобы класс передачи «Большие Гонки» не изменял свой функционал, а добавлял 
            новый. В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и чтобы они сыграли в 6 игр.
            Какие игры создать: 
            1. Пляж
            2. Мышеловка
            3. Море
            4. Рыбалка
            5. Почтальоны
            6. Горка
            Также вам необходимо создать свою игру, но не изменяя класс, а расширяя функционал класса. Подумайте, какой паттерн
            нужно использовать.*/
            Console.WriteLine("Большие гонки");

            Team russia = new Team("Россия");
            Team france = new Team("Франция");
            Team china = new Team("Китай");
            Team kazakhstan = new Team("Казахстан");

            Game beach = new Beach();
            Game mousetrap = new Mousetrap();
            Game sea = new Sea();
            Game fishing = new Fishing();
            Game postmen = new Postmen();
            Game slide = new Slide();
            Game newGame = new NewGame();

            russia.AddGame(beach);
            russia.AddGame(mousetrap);
            russia.AddGame(sea);
            russia.AddGame(fishing);
            russia.AddGame(postmen);
            russia.AddGame(slide);
            russia.AddGame(newGame);

            france.AddGame(beach);
            france.AddGame(mousetrap);
            france.AddGame(sea);
            france.AddGame(fishing);
            france.AddGame(postmen);
            france.AddGame(slide);
            france.AddGame(newGame);

            china.AddGame(beach);
            china.AddGame(mousetrap);
            china.AddGame(sea);
            china.AddGame(fishing);
            china.AddGame(postmen);
            china.AddGame(slide);
            china.AddGame(newGame);

            kazakhstan.AddGame(beach);
            kazakhstan.AddGame(mousetrap);
            kazakhstan.AddGame(sea);
            kazakhstan.AddGame(fishing);
            kazakhstan.AddGame(postmen);
            kazakhstan.AddGame(slide);
            kazakhstan.AddGame(newGame);

            BigRace bigRace = new BigRace();
            bigRace.AddTeam(russia);
            bigRace.AddTeam(france);
            bigRace.AddTeam(china);
            bigRace.AddTeam(kazakhstan);

            bigRace.StartRace();
        }
    }
}