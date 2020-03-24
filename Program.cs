using System;
using bb_mvc.Controllers;

namespace bb_mvc
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockbusterController bb = new BlockbusterController();
            bb.Run();
        }
    }
}
