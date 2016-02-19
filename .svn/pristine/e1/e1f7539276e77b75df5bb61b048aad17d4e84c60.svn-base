using System;

namespace Harvester
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            //This replaces the using statement as Engine is now a singleton
            //Nothing is broken
            //For more information about the using statement that was replaced http://msdn.microsoft.com/en-us/library/yh598w02.aspx
            //Run the game
            Engine.Instance.Run();
            
            //End the game and dispose of all the remaining Reasoureces
            Engine.Instance.Dispose();
        }
        
    }
#endif
}

