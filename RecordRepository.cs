namespace reflexor;

using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

class RecordRepository
{
    public static List<Record> GetRecords()
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            PrepareHeaderForMatch = args => args.Header.ToLower(),
            Delimiter = ",",
        };
        using (var reader = new StreamReader("records.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            return csv.GetRecords<Record>().OrderBy(o => o.Seconds).ToList();
        }
    }

    public static List<Record> GetRecords(int max)
    {
        return GetRecords().Take(max).ToList();
    }

    public static int GetRank(double seconds)
    {
        var records = GetRecords();
        var index = records.FindIndex(x => x.Seconds > seconds);
        if (index == -1)
        {
            return records.Count();
        }
        return index;
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
