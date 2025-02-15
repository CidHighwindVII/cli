﻿using Cmf.CLI.Utilities;
using System;
using System.CommandLine;
using System.Linq;
using System.Threading.Tasks;
using Cmf.CLI.Commands;
using Cmf.CLI.Core;
using Cmf.CLI.Core.Objects;
using Microsoft.Extensions.DependencyInjection;
using Cmf.CLI.Core.Enums;
using Cmf.CLI.Constants;
using System.CommandLine.Builder;
using System.Diagnostics;

namespace Cmf.CLI
{
    /// <summary>
    /// program entry point
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">Console application input arguments</param>
        /// <returns></returns>
        public static async Task<int> Main(string[] args)
        {
            try
            {
                var rootCommand = await StartupModule.Configure(
                    packageName: "@criticalmanufacturing/cli",
                    envVarPrefix: "cmf_cli",
                    description: "Critical Manufacturing CLI",
                    args: args);

                using var activity = ExecutionContext.ServiceProvider.GetService<ITelemetryService>()!.StartActivity("Main");

                var result = -1;
                
                if (rootCommand != null)
                {
                    BaseCommand.AddPluginCommands(rootCommand);
                    result = await rootCommand.InvokeAsync(args);
                }
                 
                activity?.SetTag("execution.success", true);
                return result;
            }
            catch (CliException e)
            {
                Log.Error(e.Message);
                Log.Debug(e.StackTrace);
                return (int)e.ErrorCode;
            }
            catch (Exception e)
            {
                Log.Debug("Caught exception at program.");
                Log.Exception(e);
                ExecutionContext.ServiceProvider.GetService<ITelemetryService>()!.LogException(e);
                return (int)ErrorCode.Default;
            }
        }
    }
}