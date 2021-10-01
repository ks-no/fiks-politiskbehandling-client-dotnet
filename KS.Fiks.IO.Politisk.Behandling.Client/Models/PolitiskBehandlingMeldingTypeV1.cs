namespace KS.Fiks.IO.Politiskbehandling.Client.Models
{
    public class PolitiskBehandlingMeldingTypeV1
    {
        // Forespørsler
        public const string HentMøteplan = "no.ks.fiks.politisk.behandling.klient.hentmøteplan.v1";
        public const string HentUtvalg = "no.ks.fiks.politisk.behandling.klient.hentutvalg.v1";
        
        // Resultat
        public const string ResultatMøteplan = "no.ks.fiks.politisk.behandling.tjener.resultatmøteplan.v1";
        public const string ResultatUtvalg = "no.ks.fiks.politisk.behandling.tjener.resultatutvalg.v1";
        public const string ResultatSendVedtakFraUtvalg = "no.ks.fiks.politisk.behandling.tjener.sendvedtakfrautvalg.v1";
        public const string ResultatSendVedtakFraUtvalgKvittering = "no.ks.fiks.politisk.behandling.tjener.sendvedtakfrautvalg.kvittering.v1";
        public const string Mottatt = "no.ks.fiks.politisk.behandling.mottatt.v1";
        
        // Innsendelser
        public const string SendUtvalgssak = "no.ks.fiks.politisk.behandling.klient.sendutvalgssak.v1";
        public const string SendUtvalgssakKvittering = "no.ks.fiks.politisk.behandling.klient.sendutvalgssak.kvittering.v1";
        public const string SendOrienteringssak = "no.ks.fiks.politisk.behandling.klient.sendorienteringssak.v1";
        public const string SendOrienteringssakKvittering = "no.ks.fiks.politisk.behandling.klient.sendorienteringssak.kvittering.v1";
        public const string SendDelegertVedtak = "no.ks.fiks.politisk.behandling.klient.senddelegertvedtak.v1";
        public const string SendDelegertVedtakKvittering = "no.ks.fiks.politisk.behandling.klient.senddelegertvedtak.kvittering.v1";
        
        // eInnsyn
        public const string SendMøteplanTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendmøteplan.v1";
        public const string SendUtvalgssakerTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendutvalgssaker.v1";
        //public const string SendMøtedokumenterTilEInnsyn = "";
        public const string SendVedtakTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendvedtak.v1";
    }
}