using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace PHMS
{
    class Staff
    {
        private static string _name;
        private static int _age;
        private static long _contact;
        public static int count;
        private static DataTable dt = new DataTable();
        private static DataTable dt2 = new DataTable();
        private static string[][] MergeSort(string[][] arr)
        {
            int n = arr.Length;
            if (n < 2)
            {
                return arr;
            }
            int mid = n / 2;
            string[][] left = new string[mid][];
            string[][] right = new string[n - mid][];
            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, n - mid);
            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }
        private static string[][] Merge(string[][] left, string[][] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int totalLength = leftLength + rightLength;
            string[][] merged = new string[totalLength][];
            int i = 0, j = 0, k = 0;
            while (i < leftLength && j < rightLength)
            {
                if (String.Compare(left[i][1], right[j][1], StringComparison.Ordinal) <= 0)
                {
                    merged[k] = left[i];
                    i++;
                }
                else
                {
                    merged[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < leftLength)
            {
                merged[k] = left[i];
                i++;
                k++;
            }
            while (j < rightLength)
            {
                merged[k] = right[j];
                j++;
                k++;
            }
            return merged;
        }
        public Staff()
        {

        }
        public static int Id { get; set; }
        public static string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 5)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Name should be more than 5 characters.");
                }
            }
        }

        public static int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age should be greater or equal to 18.");
                }
            }
        }

        public static decimal Salary { get; set; }

        public static string Wrk_hrs { get; set; }

        public static long Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                if (value.ToString().Length == 11)
                {
                    _contact = value;
                }
                else
                {
                    throw new Exception("Your contact no. should be 11 characters.");
                }
            }
        }

        static Staff()
        {
            dt.Columns.Add("Employee ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(string));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("work Hrs", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
        }
        

        public static DataTable Staffshow()
        {
            StreamReader sreader = new StreamReader("staffdetails.txt");
            try
            {
                count = 0;
                dt.Clear();
                string line;
                while ((line = sreader.ReadLine()) != null)
                {
                    string[] data = line.Split(new string[] { "|" }, StringSplitOptions.None);
                    string[] row = new string[data.Length];
                    for (int i = 0; i < row.Length; i++)
                    {
                        row[i] = data[i].Trim();
                    }
                    dt.Rows.Add(row);
                    count++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sreader.Close();
            return dt;
        }

        public static DataTable SearchId()
        {
            
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Employee ID", typeof(int));
            dt1.Columns.Add("Name", typeof(string));
            dt1.Columns.Add("Age", typeof(string));
            dt1.Columns.Add("Salary", typeof(double));
            dt1.Columns.Add("work Hrs", typeof(string));
            dt1.Columns.Add("Contact", typeof(string));

            using (StreamWriter sr = new StreamWriter("searchdata.txt"))
            using (StreamReader sreader = new StreamReader("staffdetails.txt"))
            {
                try
                {
                    string line;
                    while ((line = sreader.ReadLine()) != null)
                    {
                        string[] data = line.Split(new string[] { "|" }, StringSplitOptions.None);
                        string[] row = new string[data.Length];
                        for (int i = 0; i < row.Length; i += 6)
                        {
                            row[i] = data[i].Trim();
                            if (int.Parse(row[i]) == Id)
                            {
                                for (int j = i; j < row.Length - 1; j++)
                                {
                                    row[j] = data[j].Trim();
                                    sr.Write(row[j] + "|");
                                }
                                sr.WriteLine();
                                break;
                            }
                        }
                    }
                }
                catch
                {

                }
            }
            using (StreamReader st = new StreamReader("searchdata.txt"))
            {
                try
                {

                    string line;
                    while ((line = st.ReadLine()) != null)
                    {
                        string[] data1 = line.Split(new string[] { "|" }, StringSplitOptions.None);
                        string[] row1 = new string[data1.Length];
                        for (int k = 0; k < row1.Length; k++)
                        {
                            row1[k] = data1[k].Trim();
                        }
                        dt1.Rows.Add(row1);
                    }
                }
                catch
                {

                }
            }

            return dt1;
        }
        public static void Register()
        {
            try
            {

                StreamWriter stw = new StreamWriter("staffdetails.txt", true);
                stw.WriteLine($"{Id}|{Name}|{Age}|{Salary}|{Wrk_hrs}|{Contact.ToString()}");
                stw.Close();
                StreamReader sreader = new StreamReader("staffdetails.txt");
                string line;
                List<string[]> rows = new List<string[]>();
                while ((line = sreader.ReadLine()) != null)
                {
                    string[] data = line.Split(new string[] { "|" }, StringSplitOptions.None);
                    string[] row = new string[data.Length];
                    for (int i = 0; i < row.Length; i++)
                    {
                        row[i] = data[i].Trim();
                    }
                    rows.Add(row);
                }
                sreader.Close();
                string[][] sortedRows = MergeSort(rows.ToArray());
                StreamWriter sw = new StreamWriter("staffdetails.txt", false);
                foreach (string[] row in sortedRows)
                {
                    sw.WriteLine(string.Join("|", row));
                }
                sw.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
    }
}