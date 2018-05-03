using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("test01.json"))
            {
                string JsonFileData = r.ReadToEnd();
                List<RootObject> items = JsonConvert.DeserializeObject<List<RootObject>>(JsonFileData);  
                foreach (var item in items)
                {
                    Console.WriteLine("縣市 :{0} 實際用途:{1} 每月租金:{2} 租期屆滿:{3} \n", item.縣市, item.實際用途, item.每月租金, item.租期屆滿);
                }
                Console.WriteLine("標題:臺鐵局房地產出租情形," + "總資料組筆數 : " + items.Count + "\n");
            }
            Console.ReadLine();
        }
    }
    public class RootObject
    {
        public string 縣市 { get; set; }
        public string 實際用途 { get; set; }
        public string 每月租金 { get; set; }
        public string 租期屆滿 { get; set; }
    }
}
