using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLead
{
    class DataSet
    {
        private List<List<string>> data = new List<List<string>>();

        string getCell(int row, int column)
        {
            return data[row][column];
        }

        List<string> getRow(int row)
        {
            return data[row];
        }

        void addRow(List<string> value)
        {
            data.Add(value);
        }

        void editCell(int row, int column, string value)
        {
            data[row][column] = value;
        }

        void exportToExcel()
        {
            // To be developed later
        }
    }
}
