
namespace Syslib.Core.Application
{
	internal class BugCheck_Application
	{
		public void Run()
		{
			Console.WriteLine("EXAMPLES: BugCheck ----------------------------------------");

			LogErrorsToFile();				// silent logging to file
			LogCriticalErrors();		    // Log critical message and generate an exception

			BugCheck.DebugMode(true);		// setting debugmode to true will generate exception also for silent logging
			LogErrorsToFileDebugMode();		// log message and generate an exception
			BugCheck.DebugMode(false);		// set debugmode to false (default)


			LogToMemory();					// silent logging to memory
			SaveMemoryLog();				// Save memory logged messages to file


		}


		void LogErrorsToFile()
		{
			BugCheck.Log(this, "Log message sent from bugcheck example");
			Console.WriteLine("Bugcheck silently appended message to file _BUGCHECK.log");
		}

		void LogCriticalErrors()
		{
			try
			{
				BugCheck.Critical(this, "Log Critical message sent from bugcheck example");
			}
			catch
			{
				Console.WriteLine("Bugcheck Logged critical message to file and generate an exception");
			}
		}

		void LogErrorsToFileDebugMode()
		{
			try
			{
				BugCheck.Log(this, "Log message sent from bugcheck example");
			}
			catch
			{
				Console.WriteLine("Bugcheck (debugmode) logged appended message to file and generate an exception");
			}
		}



		void LogToMemory()
		{
			int i;
			for (i = 0; i < 10; i++)  BugCheck.MemLogger(this, "Log message sent from bugcheck example");
			Console.WriteLine($"Bugcheck silently logged {i} messages to memory");
		}

		void SaveMemoryLog()
		{
			BugCheck.SaveMemLogger();
			Console.WriteLine("Bugcheck silently appended logged items in memory to file _BUGCHECKmem.log");
		}




	}
}
