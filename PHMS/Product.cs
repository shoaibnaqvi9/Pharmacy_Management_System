using System;
using System.IO;
using System.Data;
using Guna.UI2.AnimatorNS;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PHMS
{
    class Product : Exception
    {
        protected static DataTable dt = new DataTable();
        private readonly static Random r = new Random();
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
                if (string.Compare(left[i][1], right[j][1], StringComparison.Ordinal) <= 0)
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

        public static int count
        {
            get;
            set;
        }

        public static int ID { get; set; }

        public static string Category { get; set; }

        public static string Name { get; set; }

        public static double Price { get; set; }

        public static int Quantity { get; set; }

        static Product()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
        }

        public Product()
        {

        }
        public static DataTable Productshow()
        {
            StreamReader sreader = new StreamReader("productdetails.txt");
            try
            {
                count = 0;

                dt.Rows.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sreader.Close();
            return dt;
        }
        public static DataTable Search()
        {
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("ID", typeof(int));
            dt1.Columns.Add("Name", typeof(string));
            dt1.Columns.Add("Category", typeof(string));
            dt1.Columns.Add("Price", typeof(double));
            dt1.Columns.Add("Quantity", typeof(int));

            using (StreamWriter sr = new StreamWriter("searchdata.txt"))
            using (StreamReader sreader = new StreamReader("productdetails.txt"))
            {

                string line;
                while ((line = sreader.ReadLine()) != null)
                {
                    string[] data = line.Split(new string[] { "|" }, StringSplitOptions.None);
                    string[] row = new string[data.Length];
                    for (int i = 0; i < row.Length; i += 6)
                    {
                        row[i] = data[i].Trim();
                        if (int.Parse(row[i]) == ID)
                        {
                            for (int j = i; j < row.Length; j++)
                            {
                                row[j] = data[j].Trim();
                                sr.Write(row[j]);
                                if (j == dt1.Columns.Count - 1)
                                {
                                    continue;
                                }
                                sr.Write("|");
                            }
                            sr.WriteLine();
                            break;
                        }
                    }
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            return dt1;

        }

        public static void Enter()
        {
            StreamWriter stw = new StreamWriter("productdetails.txt", true);
            stw.WriteLine($"{ID}|{Name}|{Category}|{Price}|{Quantity}");
            stw.Close();

            StreamReader sreader = new StreamReader("productdetails.txt");
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

            StreamWriter sw = new StreamWriter("productdetails.txt", false);

            foreach (string[] row in sortedRows)
            {
                sw.WriteLine(string.Join("|", row));
            }
            sw.Close();


        }


    }
}

