using System;

namespace MyUrlLibrary
{
    public class MyUrlParse
    {
        public string scheme;
        public bool valid;
        
        public void MakeParsing(string s)
        {
            int index;
            string url = s;

            try
            {
                Uri myUri = new Uri(url);
                valid = true;
                index = s.IndexOf(':');
                scheme = s.Substring(0,index);
            }
            catch
            {
                valid = false;

            }
        }
    }
}
