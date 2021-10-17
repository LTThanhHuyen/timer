using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicControl.Entities
{
    public class HistoryLearning
    {
        public string SchoolName {  get; set; }
        public string SchoolAddress {  get; set; }   
        public int YearBegin {  get; set; }
        public int YearEnd {  get; set;}
        public float Mark {  get; set; }
        public string Rank
        {
            get
            {
                if (Mark < 5)
                    return "Yếu";
                if (Mark < 7)
                    return "Trung bình";
                if (Mark < 8)
                    return "Khá";
                if (Mark < 9)
                    return "Giỏi";
                else return "Xuất sắc";
            }
        }
        public static List<HistoryLearning> GetList(string idStudent)
        {
            List<HistoryLearning> list = new List<HistoryLearning>();
            list.Add(new HistoryLearning {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Tiểu học Chi Lăng",
                YearBegin = 2006,
                YearEnd = 2011,
                Mark = 8
            });
            list.Add(new HistoryLearning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Trung học Chi Lăng",
                YearBegin = 2011,
                YearEnd = 2015,
                Mark = 9
            });
            list.Add(new HistoryLearning
            {
                SchoolAddress = "Chi Lăng, Huế",
                SchoolName = "Phổ thông Chi Lăng",
                YearBegin = 2015,
                YearEnd = 2018,
                Mark = 7
            });
            return list;
        }
    }
}
