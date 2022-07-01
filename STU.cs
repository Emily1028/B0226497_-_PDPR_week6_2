using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week6_2
{
    public class STU
    {
        private int CHI, ENG, MATH;
        private double AVG;
        public int chi
        {
            get { return CHI; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                CHI = value;
            }
        }
        public int eng
        {
            get { return ENG; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                ENG = value;
            }
        }
        public int math
        {
            get { return MATH; }
            set
            {
                if (value > 100)
                    value = 100;
                else if (value < 0)
                    value = 0;
                MATH = value;
            }
        }
        public double avg
        {
            get { return (CHI + ENG + MATH) / 3; }
        }
        public string ID { set; get; }
        public string NAME { set; get; }
        public string PHONE { set; get; }
        public string PRINTME()
        {
            return $"學號:{ID}，姓名:{NAME}，電話:{PHONE}，國:{chi}，英:{eng}，數:{math}，平均:{avg.ToString("0.0")}";
        }
        public STU(string id,string name,string phone,int chi,int eng,int math)
        {
            ID =id;
            NAME = name;
            PHONE = phone;
            CHI = chi;
            ENG = eng;
            MATH = math;
        }
        public STU()
        {
            ID = "B0226497";
            NAME = "段昱如";
            PHONE = "000000";
            CHI = 0;
            ENG = 0;
            MATH = 0;
        }
        public STU(int chi, int eng, int math)
        {
            ID = "B0226497";
            NAME = "段昱如";
            PHONE = "000000";
            CHI = chi;
            ENG = eng;
            MATH = math;
        }
        public STU(string id, string name, string phone)
        {
            ID = id;
            NAME = name;
            PHONE = phone;
            CHI = 0;
            ENG = 0;
            MATH = 0;
        }
    }
}
