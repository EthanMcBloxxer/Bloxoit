using System;
using System.IO;
namespace Bloxoit
{
	class Program
	{
		static void Main(string[] args)
		{
			args = Array.ConvertAll(args, d => d.ToLower());

			WeAreDevs_API.ExploitAPI wrd = new WeAreDevs_API.ExploitAPI();

			var command = args[0];
			switch (command)
			{
				case "api":
					if (args[1] == "wrd" || args[1] == "wearedevs" || args[1] == "--wrd" || args[1] == "--wearedevs" || args[1] == "--we-are-devs")
					{
						File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Bloxoit\\api.txt", "wrd");
					}
					break;
				case "execute" when args.Length == 1 && args[1] == "--clipboard":
					break;
				case "execute":
					string ext = Path.GetExtension(@args[1]);
					if (ext == String.Empty || ext == ".txt" || ext == ".text" || ext == ".lua")
					{
						Execute(args[1]);
					}
					else
					{
						if (args.Length == 2 && args[2] == "--force" || args[2] == "-f")
						{
							Execute(args[1]);
						}
						else
						{
							Console.WriteLine("Bloxoit won't run this file unless the file extension is nothing, `txt`, `text`, or `lua`.");
							Console.WriteLine("Silence this with --force (-f).");
						}
					}
					break;
				default:
					Console.WriteLine(command + " is not recognized as a Bloxoit command.");
					break;
			}
		}
		static void Execute(string file)
		{
			switch (File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Bloxoit\\api.txt"))
			{
				case "wrd":

				default:
					// wrd api is default
					break;
			}
			File.ReadAllText(file);
		}
	}
}
