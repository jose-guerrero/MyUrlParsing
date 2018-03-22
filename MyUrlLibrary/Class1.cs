﻿using System;

namespace MyUrlLibrary
{
    public class MyUrlParse
    {
        public string scheme;
        public string user;
        public string password;
        public string host;
        public string port;
        public bool valid;
        
        public void MakeParsing(string s)
        {
            int index,index2;
            string url = s;
            string temp; 

            try
            {
                Uri myUri = new Uri(url);
                valid = true;
                ///Scheme

                index = url.IndexOf(':');

                scheme = url.Substring(0, index);
                url = url.Substring(index + 1, url.Length - index - 1);
                
                ///UserInfo (User, Password)
                 
                user = "";
                password = "";
                 
                int i = 0;
                 
                while (url[i]=='/')   
                {
                     i++;
                }
                
                url = url.Substring(i,url.Length - i);
                index = url.IndexOf('@');
                
                if (index != -1)  /// theres @ 
                {
                    index2 = url.IndexOf(':');
                    
                    if (index2 == -1)
                    {
                        user = url.Substring(0, index);
                    }
                    else
                    {
                        user = url.Substring(0, index2);
                        password = url.Substring(index2 + 1, index - index2 - 1);
                    }
                    url = url.Substring(index + 1, url.Length - index - 1);
                }

                /// Host, Port
                index = url.IndexOf('/');
                temp = url.Substring(0, index);

                index2 = temp.IndexOf(':');
                url = url.Substring(index, url.Length - index);

                if (index2 == -1)
                {
                    host = temp;
                    port = "";
                }
                else
                {
                    host = temp.Substring(0, index2);
                    port = temp.Substring(index2 + 1, index - index2 - 1);
                }

            }
            catch
            {
                valid = false;

            }
        }
    }
}
