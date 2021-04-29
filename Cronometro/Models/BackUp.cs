using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Cronometro.Models
{
    public class BackUp
    {
        private static string FilePath
        {
            get { return Environment.CurrentDirectory + '\\'; }
        }
        private static string FileName
        {
            get { return (FilePath + $"bkp{DateTime.Now:yyMMddHHMMss}.crn"); }
        }
        public static void Save (List<string> data)
        {
            File.WriteAllLines(FileName, data);
        }
        public static List<string> Load (DateTime dateTime)
        {
            return File.ReadAllLines(FilePath + $"bkp{dateTime:yyMMddHHMMss}.crn").ToList();
        }
        public static bool Exists(out DateTime date)
        {
            date = new DateTime();
            if (File.Exists(GetLast()))
            {
                date = GetDateTime(Directory.EnumerateFiles(FilePath , "*.crn").FirstOrDefault());
                return true;
            }
            return false;
        }
        public static void Depure (DateTime date)
        {
            foreach (string crn in Directory.EnumerateFiles(FilePath , $"bkp{DateTime.Now:yyMMdd}*.crn"))
            {
                if (GetDateTime(crn) <= date)
                    File.Delete(crn);
            }
        }
        public static void DepureAll ()
        {
            foreach (string crn in Directory.EnumerateFiles(FilePath, "*.crn"))
                File.Delete(crn);
        }
        public static DateTime GetDateTime (string fileName)
        {
            return DateTime.ParseExact(fileName.Replace(FilePath,"").Substring(3, 12), "yyMMddHHMMss", null);
        }

        public static string GetLast()
        {
            if (Directory.EnumerateFiles(FilePath, $"bkp*.crn").Count() > 0)
            {
                string last = Directory.EnumerateFiles(FilePath, $"bkp*.crn").First();
                DateTime lastTime = GetDateTime(last);
                foreach (string crn in Directory.EnumerateFiles(FilePath, $"bkp*.crn"))
                {
                    if (GetDateTime(crn) > lastTime)
                        last = crn;
                }
                return last;
            }
            else return string.Empty;
        }
        public static void ToMasterBackUp(string filename)
        {
            File.Copy(filename, $"{DateTime.Now:yyyyMMddHHmmss}" + ".bkp");
        }

        public static void DepureMasterBackUp()
        {
            foreach (string file in Directory.EnumerateFiles(FilePath, "*.bkp"))
            {
                if (DateTime.ParseExact(file.Replace(FilePath, "").Split('.')[0], "yyyyMMddHHmmss", null) <= DateTime.Now.AddDays(-10))
                    File.Delete(file);
            }
        }
    }
}
