using System.Diagnostics;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Downloading;

class Program
{
    static async Task Main(string[] args)
    {
        Stopwatch s = new Stopwatch();
        s.Start();
        using var client = new HttpClient();

        string result = await client.GetStringAsync("https://www.tabnak.ir/");
        string hrefPattern = @"(?:href)\s*=\s*[""'](?<url>https?://[^""']+)[""']";
        string srcPattern = @"(?:src)\s*=\s*[""'](?<url>https?://[^""']+)[""']";

        var hrefMatches = Regex.Matches(result, hrefPattern, RegexOptions.IgnoreCase);
        var hrefUrls = hrefMatches.Select(m => m.Groups["url"].Value).ToList();

        var tasks = hrefUrls.Select(async relativeUrl =>
        {
            try
            {
                string secondaryResult = await client.GetStringAsync(relativeUrl);
                // string secondaryResult = client.GetStringAsync(relativeUrl).Result;
                var srcMatches = Regex.Matches(secondaryResult, srcPattern, RegexOptions.IgnoreCase);

                var downloadTasks = srcMatches.Select(async srcMatch =>
                {
                    try
                    {
                        string fileUrl = srcMatch.Groups["url"].Value;
                        byte[] bytes = await client.GetByteArrayAsync(fileUrl);
                        string filename = Path.GetFileName(fileUrl);

                        File.WriteAllBytes(filename, bytes);
                        Console.WriteLine($"{filename} => {fileUrl}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                });

                await Task.WhenAll(downloadTasks);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });

        await Task.WhenAll(tasks);
        s.Stop();
        Console.WriteLine(s.Elapsed.TotalSeconds);

        // در این تمرین در ساختاری که task  تعریف نشده بود 917 ثانیه طول کشید ولی با تعریف تسک و انجام موازی انها فقط 52 ثانیه زمان برد
    }
}
