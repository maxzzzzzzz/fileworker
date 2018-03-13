using System;
using FileWorker.Interfaces;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
namespace FileWorker
{
    class FileManager : IFileManager
    {
        public DataTable ReadPersonFromFile(string pathFile)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("surname", typeof(string)));
            dt.Columns.Add(new DataColumn("age", typeof(int)));
            dt.Columns.Add(new DataColumn("email", typeof(string)));
            var data = Directory.EnumerateFiles(pathFile).Select(File.ReadAllText);
            foreach (var v in data)
            {
                foreach (var s in v.Split('\n'))
                {
                    var ss = s.Split();
                    DataRow nr = dt.NewRow();
                    nr[0] = Convert.ToInt32(ss[0]);
                    nr[1] = Convert.ToString(ss[1]);
                    nr[2] = Convert.ToString(ss[2]);
                    nr[3] = Convert.ToInt32(ss[3]);
                    //nr[4] = Convert.ToString(ss[4]);
                    //nr[2] = ss[2];
                    dt.Rows.Add(nr);
                }
            }
            return dt;
        }
        public List<Unit> ReadUnitsFromFile(string pathName) { return new List<Unit>(); }
        public List<Order> ReadOrdersFromFile(string pathName) { throw new NotImplementedException(); }

    }
}
