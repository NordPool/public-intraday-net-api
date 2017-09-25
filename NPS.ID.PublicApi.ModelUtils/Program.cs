using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPS.ID.PublicApi.ModelUtils
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }
        static async Task MainAsync(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    Console.Error.WriteLine($@"No paths given. Run command with 2 arguments: NPS.ID.PublicApi.ModelUtils.exe ""SCHEMAPATH"" ""OUTPUTPATH""");
                    return;
                }
                var schemaPath = args[0];
                var outputPath = args[1];

                if (!Directory.Exists(schemaPath))
                {
                    Console.Error.WriteLine($"Invalid schema path: {schemaPath}");
                    return;
                }

                if (!Directory.Exists(outputPath))
                {
                    Console.Error.WriteLine($"Invalid output path: {outputPath}");
                    return;
                }

                var schemaFolder = new DirectoryInfo(schemaPath);
                var i = 0;
                foreach (var schemaFile in schemaFolder.EnumerateFiles())
                {
                    var contents = File.ReadAllText(schemaFile.FullName);
                    var schema = await NJsonSchema.JsonSchema4.FromJsonAsync(contents);
                                        
                    var generator = new CSharpGenerator(schema);
                    generator.Settings.ArrayType = "System.Collections.Generic.List";
                    generator.Settings.Namespace = "NPS.ID.PublicApi.Models";
                    generator.Settings.DateTimeType = "System.DateTimeOffset";
                    generator.Settings.ClassStyle = CSharpClassStyle.Poco;
                    var csCode = generator.GenerateFile();
                    File.WriteAllText(Path.Combine(outputPath, $"{schema.Title}.cs"), csCode);
                    i++;
                }

                Console.Out.WriteLine($"{i} files generated.");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
