namespace Datastrukturer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indx = 3;
            string[] strang = {"kage","sovs","pap","ur","tv","lys","led"};
            string tilsat = "ord";
        }
        static private (bool, string[]) Op_3(int indx, string tilsat, string[] strang)
        {
            string[] temp = new string[strang.Length + 1];
            if (indx <= temp.Length && indx >= 0)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i < indx)
                    {
                        temp[i] = strang[i];

                    }
                    else if (i == indx)
                    {
                        temp[i] = tilsat;
                    }
                    else
                    {
                        
                        temp[i] = strang[i-1];
                    }
                }
            
                return (true, temp);
            }
            else { return (false, strang); }
        }
    }
}