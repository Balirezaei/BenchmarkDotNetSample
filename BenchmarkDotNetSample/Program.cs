// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using BenchmarkDotNetSample;

var config =  new ManualConfig()
     .WithOptions(ConfigOptions.DisableOptimizationsValidator)
     .AddValidator(JitOptimizationsValidator.DontFailOnError)
     .AddLogger(ConsoleLogger.Default)
     .AddColumnProvider(DefaultColumnProviders.Instance);

Console.WriteLine(BenchmarkRunner.Run<ForEachVsFor>(config));



Console.ReadLine();