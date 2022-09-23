using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2309dz
{
    public class File
    {
        public string Name { get; set; }
        public string Tip { get; set; }
        public double Size { get; set; }
        public DateTime Date { get; set; }

        public File()
        {
            Name = "Defult";
            Tip = "Defult";
            Size = 0;
            Date = DateTime.Now;
        }

        public File(string name, string tip, double size, DateTime date)
        {
            Name = name;
            Tip = tip;
            Size = size;
            Date = date;
        }

        public string Convertor()
        {
            double convert_size;

            if (Size > 0 || Size < 1000)
            {
                return Size.ToString();
            }
            else if (Size >= 1000 || Size < 1000000)
            {
                convert_size = Size / 1000;
                return convert_size.ToString();
            }
            else if(Size >= 1000000 || Size < 1000000000)
            {
                convert_size = Size / 1000000;
                return convert_size.ToString();
            }
            else if(Size >= 1000000000 || Size < 1000000000000)
            {
                convert_size = Size / 1000000000;
                return convert_size.ToString();
            }
            string str = "";
            return str;
            
        }
    }
}
