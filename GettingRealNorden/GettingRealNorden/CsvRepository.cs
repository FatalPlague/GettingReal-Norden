using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden
{
    public abstract class CsvRepository<csv>
    {
        protected List<csv> items;

        public CsvRepository()
        {
            items = new List<csv>();
            InitializeRepository();
        }

        protected abstract string Filename { get; }

        protected abstract csv CreateFromCsv(string[] parts);

        private void InitializeRepository()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Filename))   // open the CSV file
                {
                    string line = sr.ReadLine();                       // read first line

                    while (line != null)                               // loop until file ends
                    {
                        string[] parts = line.Split(',');              // split line into columns

                        csv item = CreateFromCsv(parts);               // convert CSV row into T object

                        items.Add(item);                               // add object to internal list

                        line = sr.ReadLine();                          // read next line
                    }
                }
            }
            catch (IOException)
            {
                throw;                                                 // rethrow file errors
            }
        }

        public IEnumerable<csv> GetAll() => items;                       // returns all loaded objects
    }

}

