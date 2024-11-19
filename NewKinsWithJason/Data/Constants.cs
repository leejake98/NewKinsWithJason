namespace NewKinsWithJason.Data
{
    public class Constants
    {
        // Database filename
        public const string DatabaseFilename = "workflow.json";



        // Database path
        public static string DatabasePath
        {
            get
            {
                // Set the base path to the project root folder
                var basePath = AppContext.BaseDirectory;

                // Return the full path to the database file
                return Path.Combine(basePath, "wwwroot", DatabaseFilename);
            }
        }
    }
}
