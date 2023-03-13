//using GBase.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using GProjects.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Hard_Number
{
    class HardDrive
    {
        public static string a ;
        public static string b;
       // public static int c;
        private string model = null;
        private string type = null;
        private string serialNo = null;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string SerialNo
        {
            get { return serialNo; }
            set { serialNo = value; }
        }
        public string CalculateMD5Hash(string input)
        {           
            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("X2"));

            }
            char[] arrHash = (sb.ToString()).ToCharArray();
            string SubHash = ""; ;
            for (int i = 0; i < arrHash.Length; i++)
            {
                if (i % 2 == 0)
                {
                    SubHash += arrHash[i];
                }

            }

            return SubHash;

        }
        public string NonHardDisk(string x)
        {
            string y = "";
            char[] arr = x.ToCharArray();
            for(int i=2; i<18; i++)
            {
                y += arr[i];
            }
           
            return y;
        }
        public string NumDate(string x)
        {
            string y;
            string z = "";
            char[] arr = x.ToCharArray();
            for (int i = 18; i < 26; i++)
            {
                z += arr[i];
            }
            if (z == "KAGTWMLI")
            {
                y = "0";
            }
            else y = "1";
            return y;
        }
        public string HashDate(string z)
        {
            string y = "";
            char[] x = z.ToCharArray();
            for (int i = 18; i <26; i++)
            {
                y += x[i];
            }
            return y;
        }
        public string NonDate(string x)
        {
            string y = "";
            if (x == "KAGTWMLI")
            {
                y = "09/02/2018";
            }
            else
            {
                char[] arr1 = x.ToCharArray();

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == 'A')
                    {
                        y += "0";
                    }
                    else if (arr1[i] == 'C')
                    {
                        y += "1";
                    }
                    else if (arr1[i] == 'E')
                    {
                        y += "2";
                    }
                    else if (arr1[i] == 'G')
                    {
                        y += "3";
                    }
                    else if (arr1[i] == 'I')
                    {
                        y += "4";
                    }
                    else if (arr1[i] == 'K')
                    {
                        y += "5";
                    }
                    else if (arr1[i] == 'M')
                    {
                        y += "6";
                    }
                    else if (arr1[i] == 'O')
                    {
                        y += "7";
                    }
                    else if (arr1[i] == 'Q')
                    {
                        y += "8";
                    }
                    else if (arr1[i] == 'S')
                    {
                        y += "9";
                    }
                    if (i == 1 || i == 3)
                    {
                        y += "/";
                    }
                }
            }
                return y;
            
        }
        public string HashPayment(string m)
        {
            string y = "";
            string x = "";
            char[] arr = m.ToCharArray();
            for (int i = 0; i <2; i++)
            {
                x += arr[i];
            }        
            return x;
        }
        public string NonPayment(string m)
        {
            string y = "";
            string x = "";
            char[] arr = m.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                x += arr[i];
            }
            //Options.SetOptionRegistry("ActBill", "GetBill", x);
            if (x == "3C")
            {
                y = "100";
            }
            else if (x == "4F")
            {
                y = "500";
            }
            else if (x == "1M")
            {
                y = "0";
            }
              else
              {
                  y = "0";
              }
            // b = y;
            return y;
        }
        public string NumPayment(string m)
        {
            string y = "";
            string x = "";
            char[] arr = m.ToCharArray();
            for (int i = 0; i < 2; i++)
            {
                x += arr[i];
            }
            //Options.SetOptionRegistry("ActBill", "GetBill", x);
            if (x == "3C")
            {
                y = "1";
            }
            else if (x == "4F")
            {
                y = "1";
            }
            else
            {
                y = "0";
            }
            // b = y;
            return y;
        }

        public string Hashing(string z)
        {
            string y="";
            char[] x = z.ToCharArray();
            for(int i=0;i<x.Length; i++)
            {
                if(x[i]=='0')
                {
                    y += "A";
                }
                else if(x[i]=='1')
                {
                    y += "C";
                }
                else if (x[i] == '2')
                {
                    y += "E";
                }
                else if (x[i] == '3')
                {
                    y += "G";
                }
                else if (x[i] == '4')
                {
                    y += "I";
                }
                else if (x[i] == '5')
                {
                    y += "K";
                }
                else if (x[i] == '6')
                {
                    y += "M";
                }
                else if (x[i] == '7')
                {
                    y += "O";
                }
                else if (x[i] == '8')
                {
                    y += "Q";
                }
                else if (x[i] == '9')
                {
                    y += "S";
                }
            }
            return y;
        }
        public string Payment(string x )
        {
            string y = "";
            if(x=="100")
            {
                y = "3C";
            }
            else if(x=="500")
            {
                y = "4F";
            }
            else
            {
                y = "9U";
            }
            return y;
        }
    }
}
