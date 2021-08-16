using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace KS.Fiks.IO.Politisk.Behandling.Client.Tests
{
    public class ValidateSchemasTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Validate_all_schemas_against_core_validation_dialect_meta_schema()
        {
            var jsonSchemaFilepaths = Directory.GetFiles(@"./Schema");

            var failed = false;
            
            foreach (var jsonSchemaFilepath in jsonSchemaFilepaths)
            {
                var jsonSchemaFilename = Path.GetFileName(jsonSchemaFilepath);
                
                Console.Out.WriteLine($"{jsonSchemaFilename} valideres...");
                
                var resolver = new JSchemaPreloadedResolver();
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/core"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/core").ReadToEnd() );
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/applicator"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/applicator").ReadToEnd() );
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/unevaluated"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/unevaluated").ReadToEnd() );
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/validation"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/validation").ReadToEnd() );
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/meta-data"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/meta-data").ReadToEnd() );
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/format-annotation"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/format-annotation").ReadToEnd() );
                resolver.Add(new Uri("https://json-schema.org/draft/2020-12/meta/content"), File.OpenText(@"Schema/CoreValidationDialectMetaSchema/content").ReadToEnd() );
                
                var validationSchemaReader = File.OpenText(@"Schema/CoreValidationDialectMetaSchema/schema");
                var validationSchema = JSchema.Load(new JsonTextReader(validationSchemaReader), resolver);

                var jsonSchemaReader = File.OpenText(jsonSchemaFilepath);
                var jsonSchema = JObject.Load(new JsonTextReader(jsonSchemaReader));

                try
                {
                    jsonSchema.Validate(validationSchema);
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine($"{jsonSchemaFilename} feilet!!");
                    Console.Out.WriteLine($"{jsonSchemaFilename} - Exception message: {e.Message}");
                    failed = true;
                    continue;
                }

                Console.Out.WriteLine($"{jsonSchemaFilename} var ok!");
            }

            if (failed)
            {
                Assert.Fail($"En eller flere schema var ikke godkjent!");
            }
            Assert.Pass();
        }
    }
}