using System;
using System.Collections.Generic;
using System.IO;

namespace PHMS
{
    class Account : Exception
    {
        private string username;
        private string password;
        private string filepath;
        public Account()
        {
            username = "N/A";
            password = "N/A";
        }
        public Account(string filepath)
        {
            this.filepath = filepath;
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }   
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Your password should be 8 characters or more.");
                }
            }
        }

       
        public void SignUp()
        {
            try
            {
                string usnm=Username;
                string paswor=password;
                using (StreamWriter writer = File.AppendText(this.filepath))
                {
                    writer.WriteLine($"{usnm}|{paswor}");
                }
            }
            catch (Exception)
            {
                throw new Exception("Your info is not correct");
            }
        }
        public List<Tuple<string, string>> BubbleSort(List<Tuple<string, string>> data)
        {
            int n = data.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (string.Compare(data[j].Item1, data[j + 1].Item1) > 0)
                    {
                        Tuple<string, string> temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
            return data;
        }
    }
}