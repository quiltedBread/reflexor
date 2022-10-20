namespace reflexor;

using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

class RecordRepository
{
    public static IEnumerable<Record> Records
    {
        get
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
                Delimiter = ",",
            };
            using (var reader = new StreamReader("records.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<Record>().ToList();
            }
        }
    }

    public static bool AddRecord(Record record)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            // Don't write the header again.
            HasHeaderRecord = false,
            Delimiter = ",",
        };
        using (var stream = File.Open("records.csv", FileMode.Append))
        using (var writer = new StreamWriter(stream))
        using (var csv = new CsvWriter(writer, config))
        {
            csv.WriteRecord(record);
            csv.NextRecord();
        }
        return true;
    }
}
