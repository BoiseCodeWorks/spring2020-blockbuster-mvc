using System;
using System.Threading;
using bb_mvc.Models;
using bb_mvc.Services;

namespace bb_mvc.Controllers
{
    class BlockbusterController
    {
        //create instance of service
        private bool _running { get; set; } = true;
        private BlockbusterService _bbs { get; set; } = new BlockbusterService();
        public void Run()
        {
            while (_running)
            {
                //take input
                GetUserInput();
                //process option
                //print update
                Print();
            }
        }

        private void GetUserInput()
        {
            System.Console.WriteLine("What would you like to do (view, quit, rent)");
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "quit":
                case "exit":
                case "q":
                    _running = false;
                    break;
                case "view":
                    _bbs.AddVideoMenuToMessages();
                    break;
                case "rent":
                    System.Console.Write("Enter the movie number to rent: ");
                    string indexString = Console.ReadLine();
                    _bbs.Rent(indexString);
                    break;
                default:
                    //number check here if not hanlding with "rent"
                    _bbs.Messages.Add(new Message("invalid Input", ConsoleColor.Red));
                    Thread.Sleep(1500);
                    break;
            }
        }

        private void Print()
        {
            Console.Clear();
            _bbs.Messages.Insert(0, new Message(Utils.BlockbusterLogo, ConsoleColor.Blue));
            //itterate over messages and print each one
            foreach (Message message in _bbs.Messages)
            {
                Console.ForegroundColor = message.Color;
                Console.WriteLine(message.Body);
            }
            Console.ForegroundColor = ConsoleColor.Black;
            _bbs.Messages.Clear();

        }
    }
}