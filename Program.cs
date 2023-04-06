using System.Diagnostics.Metrics;

namespace spindie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNum = new List<int>();
            int spinNum=0;
            int count = 0;
            foreach(string line in File.ReadLines(@"DATA20.txt"))
            {
                if(count == 0)
                {
                    spinNum = Convert.ToInt32(line.Trim());
                    count++;
                }
                else if (count == 1)
                {
                    string secondLine = line + ' ';
                    string tempString = "";
                    foreach (char c in secondLine)
                    {
                        if (c != ' ')
                        {
                            tempString += c;
                        }
                        else
                        {
                            listNum.Add(Convert.ToInt32(tempString));
                            tempString = "";
                        }
                    }
                    count++;
                }
                else if (count == 2)
                {
                    string secondLine = line + ' ';
                    string tempString = "";
                    int tempInt;
                    foreach (char c in secondLine)
                    {
                        if (c != ' ')
                        {
                            tempString += c;
                        }
                        else
                        {
                            tempInt = (Convert.ToInt32(tempString));
                            tempString = "";
                            for (int i = 0; i < spinNum; i++)
                            {
                                
                            }
                        }
                    }
                }
            }
        }
    }
}