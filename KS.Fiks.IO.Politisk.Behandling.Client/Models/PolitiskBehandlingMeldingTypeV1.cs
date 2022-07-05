using System.Collections.Generic;

namespace KS.Fiks.IO.Politiskbehandling.Client.Models
{
    public class PolitiskBehandlingMeldingTypeV1
    {
        // Forespørsler
        public const string HentMoeteplan = "no.ks.fiks.politisk.behandling.v1.moeteplan.hent";
        public const string HentUtvalg = "no.ks.fiks.politisk.behandling.v1.utvalg.hent";
        
        // Resultat på forespørsler
        public const string ResultatMoeteplan = "no.ks.fiks.politisk.behandling.v1.moeteplan.hent.resultat";
        public const string ResultatUtvalg = "no.ks.fiks.politisk.behandling.v1.utvalg.hent.resultat";

        // Utsendelser 
        public const string SendVedtakFraUtvalg = "no.ks.fiks.politisk.behandling.v1.vedtakfrautvalg.send";
        public const string SendVedtakFraUtvalgKvittering = "no.ks.fiks.politisk.behandling.v1.vedtakfrautvalg.send.kvittering";

        // Innsendelser
        public const string SendUtvalgssak = "no.ks.fiks.politisk.behandling.v1.utvalgssak.send";
        public const string SendUtvalgssakKvittering = "no.ks.fiks.politisk.behandling.v1.utvalgssak.send.kvittering";
        public const string SendOrienteringssak = "no.ks.fiks.politisk.behandling.v1.orienteringssak.send";
        public const string SendOrienteringssakKvittering = "no.ks.fiks.politisk.behandling.v1.orienteringssak.send.kvittering";
        public const string SendDelegertVedtak = "no.ks.fiks.politisk.behandling.v1.delegertvedtak.send";
        public const string SendDelegertVedtakKvittering = "no.ks.fiks.politisk.behandling.v1.delegertvedtak.send.kvittering";

        // eInnsyn
        public const string SendMoeteplanTilEInnsyn = "no.ks.fiks.politisk.behandling.v1.eInnsyn.moeteplan.send";
        public const string SendMoeteplanTilEInnsynKvittering = "no.ks.fiks.politisk.behandling.v1.eInnsyn.moeteplan.send.kvittering";
        public const string SendUtvalgssakerTilEInnsyn = "no.ks.fiks.politisk.behandling.v1.eInnsyn.utvalgssaker.send";
        public const string SendUtvalgssakerTilEInnsynKvittering = "no.ks.fiks.politisk.behandling.v1.eInnsyn.utvalgssaker.send.kvittering";
        public const string SendVedtakTilEInnsyn = "no.ks.fiks.politisk.behandling.v1.eInnsyn.vedtak.send";
        public const string SendVedtakTilEInnsynKvittering = "no.ks.fiks.politisk.behandling.v1.eInnsyn.vedtak.send.kvittering";
        
        // Feilmeldinger
        public const string Ugyldigforespørsel = "no.ks.fiks.politisk.behandling.v1.feilmelding.ugyldigforespoersel";
        public const string Serverfeil = "no.ks.fiks.politisk.behandling.v1.feilmelding.serverfeil";
        public const string Ikkefunnet = "no.ks.fiks.politisk.behandling.v1.feilmelding.ikkefunnet";


        private static Dictionary<string, string> Skjemanavn;
        
        public static readonly List<string> FeilmeldingTyper = new List<string>()
        {
            Ugyldigforespørsel,
            Serverfeil,
            Ikkefunnet
        };

        public static string GetSkjemanavn(string meldingstypeNavn)
        {
            if (Skjemanavn == null)
            {
                initSkjemanavn();
            }
            return Skjemanavn[meldingstypeNavn];
        }

        private static void initSkjemanavn()
        {
            Skjemanavn = new Dictionary<string, string>();
            AddSkjemanavnTilDictionary(HentMoeteplan);
            AddSkjemanavnTilDictionary(ResultatMoeteplan);
            AddSkjemanavnTilDictionary(ResultatUtvalg);
            AddSkjemanavnTilDictionary(SendVedtakFraUtvalg);
            AddSkjemanavnTilDictionary(SendVedtakFraUtvalgKvittering);
            AddSkjemanavnTilDictionary(SendUtvalgssak);
            AddSkjemanavnTilDictionary(SendUtvalgssakKvittering);
            AddSkjemanavnTilDictionary(SendOrienteringssak);
            AddSkjemanavnTilDictionary(SendOrienteringssakKvittering);
            AddSkjemanavnTilDictionary(SendDelegertVedtak);
            AddSkjemanavnTilDictionary(SendDelegertVedtakKvittering);
            AddSkjemanavnTilDictionary(SendMoeteplanTilEInnsyn);
            AddSkjemanavnTilDictionary(SendMoeteplanTilEInnsynKvittering);
            AddSkjemanavnTilDictionary(SendUtvalgssakerTilEInnsyn);
            AddSkjemanavnTilDictionary(SendUtvalgssakerTilEInnsynKvittering);
            AddSkjemanavnTilDictionary(SendVedtakTilEInnsyn);
            AddSkjemanavnTilDictionary(SendVedtakTilEInnsynKvittering);
        }

        private static void AddSkjemanavnTilDictionary(string meldingstype)
        {
            Skjemanavn.Add(meldingstype, $"{meldingstype}.schema.json");
        }

        public static bool IsFeilmelding(string meldingsType)
        {
            return FeilmeldingTyper.Contains(meldingsType);
        }
    }
}