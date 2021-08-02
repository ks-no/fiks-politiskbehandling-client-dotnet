using System;
using System.IO;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

namespace KS.Fiks.IO.Politiskbehandling.Client.Generator
{
    public static class JsonSchemaToModelsGenerator
    {
        private static void Main(string[] args)
        {
            const string outputFolder = "Models";
            Directory.CreateDirectory(outputFolder);
            
            var schemaFilenames = Directory.GetFiles(@"./Schema");
            
            foreach (var schemaFilename in schemaFilenames)
            {
                var schemaFile =
                    JsonSchema.FromFileAsync(schemaFilename).Result;
                var generator = new CSharpGenerator(schemaFile);
                var classAsString = generator.GenerateFile();
                Console.Out.WriteLine($"file: {classAsString}");
                var classFilename = schemaFilename.Split('.')[6];
                File.WriteAllText($"./{outputFolder}/{ToUpper(classFilename)}.cs", classAsString);
            }
        }

        private static string ToUpper(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}