namespace KS.Fiks.IO.Politiskbehandling.Client.Models
{
    public class PolitiskBehandlingMeldingTypeV1
    {
        // Forespørsler
        public const string HentMoeteplan = "no.ks.fiks.politisk.behandling.hentmoeteplan.v1";
        public const string HentUtvalg = "no.ks.fiks.politisk.behandling.hentutvalg.v1";
        
        // Resultat på forespørsler
        public const string ResultatMoeteplan = "no.ks.fiks.politisk.behandling.resultatmoeteplan.v1";
        public const string ResultatUtvalg = "no.ks.fiks.politisk.behandling.resultatutvalg.v1";

        // Utsendelser 
        public const string SendVedtakFraUtvalg = "no.ks.fiks.politisk.behandling.sendvedtakfrautvalg.v1";
        public const string SendVedtakFraUtvalgKvittering = "no.ks.fiks.politisk.behandling.sendvedtakfrautvalg.kvittering.v1";

        // Innsendelser
        public const string SendUtvalgssak = "no.ks.fiks.politisk.behandling.sendutvalgssak.v1";
        public const string SendUtvalgssakKvittering = "no.ks.fiks.politisk.behandling.sendutvalgssak.kvittering.v1";
        public const string SendOrienteringssak = "no.ks.fiks.politisk.behandling.sendorienteringssak.v1";
        public const string SendOrienteringssakKvittering = "no.ks.fiks.politisk.behandling.sendorienteringssak.kvittering.v1";
        public const string SendDelegertVedtak = "no.ks.fiks.politisk.behandling.senddelegertvedtak.v1";
        public const string SendDelegertVedtakKvittering = "no.ks.fiks.politisk.behandling.senddelegertvedtak.kvittering.v1";

        // eInnsyn
        public const string SendMoeteplanTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendmoeteplan.v1"; //TODO er dette eller schema navn korrekt?
        public const string SendUtvalgssakerTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendutvalgssaker.v1"; //TODO er dette eller schema navn korrekt?
        public const string SendVedtakTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendvedtak.v1"; //TODO er dette eller schema navn korrekt?
    }
}