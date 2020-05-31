using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems
{

    //var map = new Dictionary<string, string>();
    //map.Add("first", "Jon");
    //    map.Add("last", "Kaufman");
    //    map.Add("extra", "Field");

    //var template = "Hello, I'm <%first%> <%last%>, and I <3 being a <%occupation%>, again my first name is <%first%>!";
    //var engine = new TemplateEngine(template);
    //Console.WriteLine(engine.compile(map));
    //    // "Hello, I'm Jon Kaufman, and I <3 being a "

    //    var map2 = new Dictionary<string, string>();
    //map2.Add("first", "Brian");
    //    map2.Add("last", "Smith");
    //    map2.Add("occupation", "Software Engineer");
    //    Console.WriteLine(engine.compile(map2));


    public class TemplateEngine
    {
        string _template = null;
        public  TemplateEngine(string template)
        {
            _template = template;
        }

        public string Compile(Dictionary<string,string> map)
        {

            StringBuilder newString = new StringBuilder();
            int i = _template.Length - 1;
            int endIndex = -1;
            int startIndex = -1;
            while (i>=2)
            {
             
                if(_template[i]=='>' && _template[i-1] == '%')
                {
                    endIndex = i - 2;
                    //newString.Insert(0, _template[i]);
                    i--;
                }

                else if (_template[i] == '%' && _template[i - 1] == '<')
                {
                    startIndex = i + 1;

                   var temp= _template.Substring(startIndex, endIndex - startIndex + 1);
                    if(map.ContainsKey(temp))
                    {
                        string tempVal = map[temp];

                        newString.Insert(0, tempVal);
                        i = startIndex - 3;

                    }
                    else
                    {
                        newString.Insert(0," ");
                        i = startIndex - 3;
                    }

                     endIndex = -1;
                     startIndex = -1;
                }
                else if(endIndex== -1)
                {
                    newString.Insert(0, _template[i]);
                    i--;
                }
                else i--;


            }
            while (i >= 0)
            {
                newString.Insert(0, _template[i]);
                i--;
            }
            return newString.ToString();




        }
    }
}
