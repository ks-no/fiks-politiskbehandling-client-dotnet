namespace KS.Fiks.IO.Politiskbehandling.Client.Models
{
    public class PolitiskBehandlingMeldingTypeV1
    {
        // Forespørsler
        public const string HentMoeteplan = "no.ks.fiks.politisk.behandling.klient.hentmoeteplan.v1";
        public const string HentUtvalg = "no.ks.fiks.politisk.behandling.klient.hentutvalg.v1";
        
        // Resultat
        public const string ResultatMoeteplan = "no.ks.fiks.politisk.behandling.tjener.resultatmoeteplan.v1";
        public const string ResultatUtvalg = "no.ks.fiks.politisk.behandling.tjener.resultatutvalg.v1";
        public const string ResultatSendVedtakFraUtvalg = "no.ks.fiks.politisk.behandling.tjener.sendvedtakfrautvalg.v1";
        public const string Mottatt = "no.ks.fiks.politisk.behandling.mottatt.v1";
        
        // Innsendelser
        public const string SendUtvalgssak = "no.ks.fiks.politisk.behandling.klient.sendutvalgssak.v1";
        public const string SendOrienteringssak = "no.ks.fiks.politisk.behandling.klient.sendorienteringssak.v1";
        public const string SendDelegertVedtak = "no.ks.fiks.politisk.behandling.klient.senddelegertvedtak.v1";
        
        // eInnsyn
        public const string SendMoeteplanTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendmoeteplan.v1";
        public const string SendUtvalgssakerTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendutvalgssaker.v1";
        //public const string SendMøtedokumenterTilEInnsyn = "";
        public const string SendVedtakTilEInnsyn = "no.ks.fiks.politisk.behandling.eInnsyn.sendvedtak.v1";
    }
}