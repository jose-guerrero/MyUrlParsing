using System;

namespace MyUrlLibrary
{
    public class MyUrlParse
    {
        public string scheme;
        public string user;
        public string password;
        public string host;
        public string port;
        public string path;
        public string query;
        public string fragment;
        public bool valid;

        public void MakeParsing(string s){
            int index,index2;
            string url = s; /// I am using url variable as I will be segmenting the original url once I find its components 
            string temp; 

            try
            {
                Uri myUri = new Uri(url); /// If url is not valid then it makes an exception
                valid = true;
                ///Scheme

                index = url.IndexOf(':');
                scheme = url.Substring(0, index);
                url = url.Substring(index + 1, url.Length - index - 1); /// Need to analyse the rest of the url only
                
                ///UserInfo (User, Password)
                 
                user = "";
                password = "";
                 
                int i = 0;
                 
                while (url[i]=='/') /// Some url contain zero, one or two '/' characters  
                {
                     i++;
                }
                
                url = url.Substring(i,url.Length - i); /// I will segment the Url such as the first character is not '/'
                index = url.IndexOf('@');
                
                if (index != -1)  /// Is there '@' ?
                {
                    index2 = url.IndexOf(':'); /// Is there ':'?
                    
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
                index = url.IndexOf('/');  /// Getting the portion (Host:Port) or (Host)
                temp = url.Substring(0, index);

                index2 = temp.IndexOf(':'); /// index2 helps to know if this segment has port component
                url = url.Substring(index, url.Length - index);

                if (index2 == -1)   /// If there's no port component then the whole segment is the host
                {
                    host = temp;
                    port = "";
                }
                else
                {
                    host = temp.Substring(0, index2);
                    port = temp.Substring(index2 + 1, index - index2 - 1);
                }

                /// Path Query Fragment

                index = url.IndexOf('?');
                index2 = url.IndexOf('#');
                path = url;
                query = "";
                fragment = "";

                if (index != -1)   /// Is there a 'Query' portion in this part of the url?
                {
                    path = url.Substring(0, index);
                    if (index2 != -1) /// Does the url contain 'Query' and 'Fragment'?
                    {
                        query = url.Substring(index, index2 - index);
                        fragment = url.Substring(index2, url.Length - index2);
                    }
                    else
                    {
                        query = url.Substring(index, url.Length - index);
                    }
                }
                else
                {
                    if (index2 != -1)   /// Is there a 'Fragment' in this part of the url?
                    {
                        path = url.Substring(0, index2);
                        fragment = url.Substring(index2, url.Length - index2);
                    }
                }     
            }
            catch(ArgumentNullException e)
            {
                // url is null
                valid = false; 
                Console.WriteLine("URI string object is a null reference: {0}",e);
            }
            catch(UriFormatException e)
            {
                // url is not valid
                valid = false;
                Console.WriteLine("URI formatting error: {0}",e);
            }
        }

        static void main()
        {
            var url = new MyUrlParse();
            url.MakeParsing("");
        }
    }
}
