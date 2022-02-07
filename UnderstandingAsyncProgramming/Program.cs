Console.WriteLine("Start");

Console.WriteLine("Number Of Logical Processors: {0}", Environment.ProcessorCount);

ThreadPool.GetMaxThreads(out int maxWorkerThreads, out int maxCompletionPortThreads);
Console.WriteLine($"Max Worker Threads: {maxWorkerThreads}. Max Completion Port Threads: {maxCompletionPortThreads}");

ThreadPool.GetMinThreads(out int minWorkerThreads, out int minCompletionPortThreads);
Console.WriteLine($"Min Worker Threads: {minWorkerThreads}. Min Completion Port Threads: {minCompletionPortThreads}");

ThreadPool.GetAvailableThreads(out int workerThreads, out int completionPortThreads);
Console.WriteLine($"Worker Threads: {workerThreads}. Completion Port Threads: {completionPortThreads}");

Console.WriteLine("Finish");

Console.ReadKey();
