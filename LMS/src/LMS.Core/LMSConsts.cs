using LMS.Debugging;

namespace LMS
{
    public class LMSConsts
    {
        public const string LocalizationSourceName = "LMS";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "04cbd2e00eb64026911c83257e20e5bb";
    }
}
