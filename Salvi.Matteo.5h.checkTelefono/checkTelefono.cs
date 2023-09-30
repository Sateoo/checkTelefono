using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        string d="";
        int f=1000;
        for(int i=0;i<input.Length;i++)
        {
            string s= input[i];
            for(int j=0;j<s.Length;j++)
            {
                if(s[j]==' ')
                    s="";
            }
            if(s.Length==13)
            {
                if(s[0]=='+' & s[1]=='3' & s[2]=='9' & f!=0)
                {
                    f=0;
                    d=s;
                }
            }
            if(s.Length==14)
            {
                if(s[0]=='0' & s[1]=='0' & s[2]=='3' & s[3]=='9' & f!=0)
                {
                    f=0;
                    d=s;
                }
            }
            if(s.Length==10)
            {
                if(s[0]=='3' & f!=0)
                {
                    f=0;
                    d=s;
                }
            }
        }
        return d;
    }    
}