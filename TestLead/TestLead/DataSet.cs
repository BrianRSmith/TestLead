using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLead
{
    public class DataSet
    {
        private List<List<string>> data;

        public DataSet()
        {
            data = new List<List<string>>();
        }

        public string getCell(int row, int column)
        {
            return data[row][column];
        }

        public List<List<string>> getData()
        {
            return data;
        }

        public List<string> getRow(int row)
        {
            return data[row];
        }

        public void addRow(List<string> value)
        {
            data.Add(value);
        }

        public void editCell(int row, int column, string value)
        {
            data[row][column] = value;
        }

        public void exportToExcel()
        {
            // To be developed later
        }
    }
}
