using System.Collections.Generic;

namespace Text_editor
{
    class Filters
    {
        private readonly List<string> Text;
        public Filters(List<string> Text) 
        {
            this.Text = Text;
        }

        public List<string> Two_filters(string condition1, string one, string to )
        {
            List<string> Text_Result = new List<string>();
            if (condition1=="И")
            {
                foreach (string a in Text)            
                    if (a.Contains(one) && a.Contains(to))
                        Text_Result.Add(a);
            }
            else if (condition1 == "ИЛИ")
            {
                foreach (string a in Text)
                    if (a.Contains(one) || a.Contains(to))
                        Text_Result.Add(a);
            }
            return Text_Result;
        }

        public List<string> Two_filters(string condition1, string one)
        {
            List<string> Text_Result  = new List<string>();
                foreach (string a in Text)
                    if (a.Contains(one))
                        Text_Result.Add(a);

            return Text_Result;
        }
    }
}
