const string folder = "FileCollection";
const string resultsfile = "results.txt";

int XLSCount = 0, DOCCount = 0, PPTCount = 0;
long XLSSize = 0, DOCSize = 0, PPTSize = 0;
long totalfiles = 0;
long totalsize = 0;

DirectoryInfo directoryInfo = new DirectoryInfo(folder);

bool IsOfficeFile(string filename) {
    // Check if the file ends with a known office suffix
    return filename.EndsWith(".xlsx") || filename.EndsWith(".docx") || filename.EndsWith(".pptx");
}

foreach (FileInfo fi in directoryInfo.EnumerateFiles())
{
    if (IsOfficeFile(fi.Name))
    {
        totalfiles++;
        totalsize += fi.Length;
        if (fi.Name.EndsWith(".xlsx"))
        {
            XLSCount++;
            XLSSize += fi.Length;
        }
        if (fi.Name.EndsWith(".docx"))
        {
            DOCCount++;
            DOCSize += fi.Length;
        }
        if (fi.Name.EndsWith(".pptx"))
        {
            PPTCount++;
            PPTSize += fi.Length;
        }
    }
}

// Output the results
using (StreamWriter sw = new StreamWriter(resultsfile))
{
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {totalfiles}");
    sw.WriteLine($"Excel Count: {XLSCount}");
    sw.WriteLine($"Word Count: {DOCCount}");
    sw.WriteLine($"PowerPoint Count: {PPTCount}");
    sw.WriteLine("----");
    sw.WriteLine($"Total Size: {totalsize:N0}");
    sw.WriteLine($"Excel Size: {XLSSize:N0}");
    sw.WriteLine($"Word Size: {DOCSize:N0}");
    sw.WriteLine($"PowerPoint Size: {PPTSize:N0}");
}