using System;
using System.Collections.Generic;
using System.IO;
using KS.Fiks.IO.Politiskbehandling.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;

namespace KS.Fiks.IO.Politisk.Behandling.Client.Tests
{
    public class MeldingTypeTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        [TestCase(PolitiskBehandlingMeldingTypeV1.HentMoeteplan)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.HentUtvalg)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.ResultatMoeteplan)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.ResultatUtvalg)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendOrienteringssak)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendUtvalgssak)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendDelegertVedtak)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendVedtakFraUtvalg)]
        public void Politisk_behandling_schema_har_tilsvarende_meldingstype_navn(string meldingstype)
        {
            Assert.IsTrue(SchemaExists(meldingstype));
        }
        
        [Test]
        [Ignore("Mismatch mellom meldingstype og schema-navn")]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendMoeteplanTilEInnsyn)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendUtvalgssakerTilEInnsyn)]
        [TestCase(PolitiskBehandlingMeldingTypeV1.SendVedtakTilEInnsyn)]
        public void Politisk_behandling_eInnsyn_schema_har_tilsvarende_meldingstype_navn(string meldingstype)
        {
            Assert.IsTrue(SchemaExists(meldingstype));
        }
        
        [Test]
        public void Moeteplan_Hent_Validering_Ok()
        {
            var jsonPath = $"Samples/moeteplan/sampleHentMoeteplan.json";
            var meldingsType = PolitiskBehandlingMeldingTypeV1.HentMoeteplan;
            
            var validationSchema = ValidationSchema(meldingsType, jsonPath, out var json);

            try
            {
                json.Validate(validationSchema);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine($"{jsonPath} feilet!!");
                Console.Out.WriteLine($"{jsonPath} - Exception message: {e.Message}");
                Assert.Fail($"Validering for {jsonPath} feilet");
            }
        }
        
        [Test]
        public void DelegertVedtak_Send_Validering_Ok()
        {
            var jsonPath = $"Samples/delegertvedtak/sampleSendDelegertVedtak.json";
            var meldingsType = PolitiskBehandlingMeldingTypeV1.SendDelegertVedtak;
            
            var validationSchema = ValidationSchema(meldingsType, jsonPath, out var json);

            try
            {
                json.Validate(validationSchema);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine($"{jsonPath} feilet!!");
                Console.Out.WriteLine($"{jsonPath} - Exception message: {e.Message}");
                Assert.Fail($"Validering for {jsonPath} feilet");
            }
        }
        
        [Test]
        public void DelegertVedtak_Send_Validering_Fail_Invalid_Properties()
        {
            var jsonPath = $"Samples/delegertvedtak/sampleSendDelegertVedtak_InvalidExtraProperties.json";
            var meldingsType = PolitiskBehandlingMeldingTypeV1.SendDelegertVedtak;
            
            var validationSchema = ValidationSchema(meldingsType, jsonPath, out var json);

            try
            {
                json.Validate(validationSchema);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine($"{jsonPath} feilet som den skal");
                Console.Out.WriteLine($"{jsonPath} - Exception message: {e.Message}");
                Assert.True(true);
                return;
            }
            Assert.Fail("Skal ikke gå gjennom som valid!");
        }
        
        [Test]
        public void Orienteringssak_Send_Validering_Ok()
        {
            var jsonPath = $"Samples/orienteringssak/sampleSendOrienteringssak.json";
            var meldingsType = PolitiskBehandlingMeldingTypeV1.SendOrienteringssak;
            
            var validationSchema = ValidationSchema(meldingsType, jsonPath, out var json);

            try
            {
                json.Validate(validationSchema);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine($"{jsonPath} feilet!!");
                Console.Out.WriteLine($"{jsonPath} - Exception message: {e.Message}");
                Assert.Fail($"Validering for {jsonPath} feilet");
            }
        }
        
        [Test]
        public void Utvalgssak_Send_Validering_Ok()
        {
            var jsonPath = $"Samples/utvalgssak/sampleSendUtvalgssak.json";
            var meldingsType = PolitiskBehandlingMeldingTypeV1.SendUtvalgssak;
            
            var validationSchema = ValidationSchema(meldingsType, jsonPath, out var json);

            try
            {
                json.Validate(validationSchema);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine($"{jsonPath} feilet!!");
                Console.Out.WriteLine($"{jsonPath} - Exception message: {e.Message}");
                Assert.Fail($"Validering for {jsonPath} feilet");
            }
        }
        
        [Test]
        public void Utvalgssak_Send_Validering_Fail_Missing_Required_Properties()
        {
            var jsonPath = $"Samples/utvalgssak/sampleSendUtvalgssak_InvalidMissingRequiredProperty.json";
            var meldingsType = PolitiskBehandlingMeldingTypeV1.SendUtvalgssak;
            
            var validationSchema = ValidationSchema(meldingsType, jsonPath, out var json);

            try
            {
                json.Validate(validationSchema);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine($"{jsonPath} feilet som den skal");
                Console.Out.WriteLine($"{jsonPath} - Exception message: {e.Message}");
                Assert.True(true);
                return;
            }
            Assert.Fail("Skal ikke gå gjennom som valid!");
        }

        private static JSchema ValidationSchema(string meldingsType, string jsonPath, out JObject json)
        {
            var resolver = new JSchemaPreloadedResolver();

            var validationSchemaReader = File.OpenText($"Schema/{meldingsType}.schema.json");
            var validationSchema = JSchema.Load(new JsonTextReader(validationSchemaReader), resolver);
            
            AddAdditionalPropertiesFalseToSchemaProperties(validationSchema.Properties);

            var jsonReader = File.OpenText(jsonPath);
            json = JObject.Load(new JsonTextReader(jsonReader));
            return validationSchema;
        }
        
        private static void AddAdditionalPropertiesFalseToSchemaProperties(IDictionary<string, JSchema> properties)
        {
            foreach (var item in properties)
            {
                item.Value.AllowAdditionalProperties = false;
                foreach (var itemItem in item.Value.Items)
                {
                    AddAdditionalPropertiesFalseToSchemaProperties(itemItem.Properties);

                }
                AddAdditionalPropertiesFalseToSchemaProperties(item.Value.Properties);
            }
        }

        private static bool SchemaExists(string meldingstype)
        {
            return File.Exists(Path.Combine("Schema", $"{meldingstype}.schema.json"));
        }
    }
}