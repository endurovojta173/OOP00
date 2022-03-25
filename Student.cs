﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP00
{
    class Student
    {
        private string jmeno;
        private int znamkaCJL;
        private int znamkaMAT;
        private int znamkaPRG;
        public Student()
        {

        }
        public Student(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public Student(string jmeno, int znamkaCJL, int znamkaMAT, int znamkaPRG)
        {
            this.jmeno = jmeno;
            this.znamkaCJL = znamkaCJL;
            this.znamkaMAT = znamkaMAT;
            this.znamkaPRG = znamkaPRG;
        }
        public string GetJmeno()
        {
            return jmeno;
        }
        public void OznamkujMAT(int znamka)
        {
            if (znamka >= 1 && znamka <= 5) znamkaMAT = znamka;
        }
        public void OznamkujCJL(int znamka)
        { 
            if (znamka >= 1 && znamka <= 5) znamkaCJL = znamka;
        }
        public void OznamkuPRG(int znamka)
        {
            if (znamka >= 1 && znamka <= 5) znamkaPRG= znamka;
        }
        public double Prumer()
        {
            if (znamkaCJL != 0 && znamkaMAT != 0 && znamkaPRG != 0)
            {
                return (double)(znamkaCJL + znamkaMAT + znamkaPRG) / 3;
            }
            else return -1;
        }
    }
}
