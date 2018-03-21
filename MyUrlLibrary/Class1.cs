using System;

namespace MyUrlLibrary
{
    public class MyUrlParse
    {
        public string scheme;
        
        public void MakeParsing(string s)
        {
            int index;

            index = s.IndexOf(':');
            scheme = s.Substring(0,index);
        }
    }
}
