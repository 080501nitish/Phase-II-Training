namespace JWT.Global_Exceptions
{
    public class StudentDetailsExceptions : Exception
    {
        public static List<string> StudentnotFoundException { get; } =
        new List<string>
            {
                "Student Not Found", 
                "",
                ""

            };

    }
}
