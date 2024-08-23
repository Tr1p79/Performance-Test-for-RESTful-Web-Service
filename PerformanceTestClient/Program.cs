using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PerformanceTestClient
{
    [SimpleJob(launchCount: 1, warmupCount: 1, iterationCount: 10)]
    [MemoryDiagnoser]
    public class PerformanceTest
    {
        private static readonly HttpClient client = new HttpClient();
        private const string url = "http://localhost:{port}/api/test"; //change port

        [Benchmark]
        public async Task TestPerformance()
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            await response.Content.ReadAsStringAsync();
        }

        [Benchmark]
        public async Task TestPerformanceWithDelay()
        {
            await Task.Delay(1000);
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            await response.Content.ReadAsStringAsync();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<PerformanceTest>();
        }


        /** private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            int numberOfRequests = 1000;
            string url = "http://localhost:{port}/api/test";
            Stopwatch stopwatch = new Stopwatch();

            long totalResponseTime = 0;
            for (int i = 0; i < numberOfRequests; i++) 
            {
                stopwatch.Start();
                var response = await client.GetAsync(url);
                stopwatch.Stop();

                long responseTime = stopwatch.ElapsedMilliseconds;
                totalResponseTime += responseTime;

                stopwatch.Reset();

                Console.WriteLine($"Response {i + 1}: {responseTime} ms");
            }

            Console.WriteLine($"Average Response Time: {totalResponseTime / numberOfRequests} ms");
        }
        **/
    }
}
