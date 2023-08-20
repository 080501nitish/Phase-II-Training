namespace Bucket.Global_Exceptions
{
    public class UserDetailsExceptions : Exception
    {
        public static Dictionary<string, string> UsernotFoundException { get; } =
            new Dictionary<string, string>
            {
                { "NotFound" , "User Not found" },
                { "AlreadyExists", "User Already Exists" }
            };
    }
}
