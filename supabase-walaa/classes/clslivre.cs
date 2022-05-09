using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace supabase_walaa.classes
{
    public class clslivre
    {
        static string url = Environment.GetEnvironmentVariable("SUPABASE_URL");
        static string key = Environment.GetEnvironmentVariable("SUPABASE_KEY");
        //static Supabase.Client instance = null;

        //public static Task<Supabase.Client> Instance { get => getInstance();}

        async public static Task<Supabase.Client> getInstance()
        {
            await Supabase.Client.InitializeAsync(url, key);

            return Supabase.Client.Instance;
            
        }
    }
}
