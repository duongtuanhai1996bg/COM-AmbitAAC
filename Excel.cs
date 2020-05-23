using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

namespace AmbitAAC
{
    public class Excel
    {

        public static void Export2Excel(DataTable dtTemp, string fileName, bool append, Encoding encoding)
        {
            if (encoding == null)
            {
                encoding = Encoding.Default;
            }
            using (var writer = new StreamWriter(fileName, append, encoding))
            {
                foreach (DataColumn dc in dtTemp.Columns)
                {
                    writer.Write(dc.ToString());
                    writer.Write('\t');
                }
                writer.Write("\r\n");
                var values = new object[dtTemp.Columns.Count];
                foreach (DataRow drTemp in dtTemp.Rows)
                {
                    values = drTemp.ItemArray;
                    foreach (var t in values)
                    {
                        writer.Write(t.ToString());
                        writer.Write('\t');
                    }
                    writer.Write("\r\n");
                }
                writer.Write("\r\n");
                writer.Close();
            }
        }
    }
}
