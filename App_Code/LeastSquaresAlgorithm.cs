using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for LeastSquaresAlgorithm
/// </summary>
public class LeastSquaresAlgorithm
{
    public static int sal1, sal2,exp1,exp2;
    public LeastSquaresAlgorithm()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int  Prediction(int s1,int s2)
    {
        Random r = new Random();
        int s = r.Next(s1, s2);
        sal1= r.Next(s1, s2);
        sal2 = r.Next(s1, s2);
        return s;
    }
    public string Apply(double sal,double expences,string  userid,string  month)
    {
        string result = "";
        Random r = new Random();
        exp1 = r.Next((int)expences - 1000, (int)expences + 1000);
        exp2 = r.Next((int)expences - 1000, (int)expences + 1000);
        if (sal > expences)
        {
            double credit = 0, debit = 0, bal = 0;
            int c = 0;
            
            ExpTable et = new global::ExpTable();
            DataTable dt = et.GetTableNum("UserId", userid);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[6].ToString().Equals("2022") && dr[5].ToString().Equals(month))
                {
                    credit = double.Parse(dr[2].ToString());
                    debit = double.Parse(dr[3].ToString());
                    bal = double.Parse(dr[4].ToString());
                    c++;
                }
            }
            double avcredit = credit / c;
            double avdebit = debit / c;
            double avbal = bal / c;
            avdebit = 0 - avdebit;
            if (avdebit + avbal > avdebit + expences)
            {
                result = "Your expences" + expences + " is under limit ";
            }
            else
            {
                result = "Your expences" + expences + " is over limit ";
            }
        }
        else
        {
            result = "Your expences " + expences + " is over limit ";
        }
        //return result  + avbal +" | "+avcredit+" | "+avdebit+" | "+dt.Rows.Count   +" | "+month  ;
        return result ;
    }
}