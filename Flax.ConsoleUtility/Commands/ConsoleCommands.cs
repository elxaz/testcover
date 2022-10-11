using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flax.ConsoleUtility.Commands
{
    internal class ExitCommand : ICommand
    {
        public string Name => "exit";
        public string Description => "The exit";

        public void Execute()
        {
            Console.ResetColor();
            Environment.Exit(1);
        }
    }
}
