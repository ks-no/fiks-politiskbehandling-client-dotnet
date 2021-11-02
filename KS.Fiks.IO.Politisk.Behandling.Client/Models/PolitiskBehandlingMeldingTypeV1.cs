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
    }
}