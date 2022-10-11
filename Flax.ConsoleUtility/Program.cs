using Flax.ConsoleUtility.Commands;
using System.Reflection;

namespace Flax.ConsoleUtil
{
	public class Program
	{
		public static void Main(params string[] args)
		{
			Console.WriteLine($"Flax.ConsoleUtility v{Assembly.GetExecutingAssembly().GetName().Version?.Major}.{Assembly.GetExecutingAssembly().GetName().Version?.Minor}");

			var commands = new List<ICommand>
			{
				new ExitCommand()
			};

			while (true)
			{
				Console.Write(">> ");
				string? init = Console.ReadLine()?.Trim();

				if (string.IsNullOrEmpty(init))
					continue;

				var command = commands.FirstOrDefault(c => c.Name == init);

				if (command == null)
				{
					Console.WriteLine($" \"{init}\" is not a command.");
					continue;
				}

				command.Execute();
			}
		}
	}
}