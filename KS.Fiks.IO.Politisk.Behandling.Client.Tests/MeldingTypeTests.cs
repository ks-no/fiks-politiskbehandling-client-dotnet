using System;
using System.IO;
using KS.Fiks.IO.Politiskbehandling.Client.Models;
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

        private static bool SchemaExists(string meldingstype)
        {
            return File.Exists(Path.Combine("Schema", $"{meldingstype}.schema.json"));
        }
    }
}