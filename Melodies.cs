using System;
using Microsoft.SPOT;
using Gadgeteer.Modules.GHIElectronics;

namespace SpiderStarTunesBT
{
    class Melodies
    {
        public Tunes.Melody jingle = new Tunes.Melody();
        public Tunes.Melody deckTheHalls = new Tunes.Melody();
        public Tunes.Melody connect = new Tunes.Melody();
        public Tunes.Melody disconnect = new Tunes.Melody();

        public Melodies()
        {
            LoadJingleBells();
            LoadDeckTheHalls();
            initConnectDisconnectTunes();
        }

        private void LoadJingleBells()
        {
            // jingle bells
            // measure 1
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 2
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 3
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.C4, 300);
            jingle.Add(Tunes.Tone.D4, 100);

            // measure 4
            jingle.Add(Tunes.Tone.E4, 800);

            // measure 5
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 300);
            jingle.Add(Tunes.Tone.F4, 100);

            // measure 6
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 100);
            jingle.Add(Tunes.Tone.E4, 100);

            // measure 7
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.E4, 200);

            // measure 8
            jingle.Add(Tunes.Tone.D4, 400);
            jingle.Add(Tunes.Tone.G4, 400);

            // measure 9
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 10
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 11
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.C4, 300);
            jingle.Add(Tunes.Tone.D4, 100);

            // measure 12
            jingle.Add(Tunes.Tone.E4, 800);

            // measure 13
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 300);
            jingle.Add(Tunes.Tone.F4, 100);

            // measure 14
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 100);
            jingle.Add(Tunes.Tone.E4, 100);

            // measure 15
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.D4, 200);

            // measure 16
            jingle.Add(Tunes.Tone.C4, 800);

            // measure 17
            jingle.Add(196, 200); // G3
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.C4, 200);

            // measure 18
            jingle.Add(196, 600); // G3
            jingle.Add(196, 100); // G3
            jingle.Add(196, 100); // G3

            // measure 19
            jingle.Add(196, 200); // G3
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.C4, 200);

            // measure 20
            jingle.Add(220, 800); // A3

            // measure 21
            jingle.Add(220, 200);  // A3
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);

            // measure 22
            jingle.Add(247, 800); //B3

            // measure 23
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.D4, 200);

            // measure 24
            jingle.Add(Tunes.Tone.E4, 800);

            // measure 25
            jingle.Add(196, 200); // G3
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.C4, 200);

            // measure 26
            jingle.Add(196, 600); // G3
            jingle.Add(196, 100); // G3
            jingle.Add(196, 100); // G3

            // measure 27
            jingle.Add(196, 200); // G3
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.C4, 200);

            // measure 28
            jingle.Add(220, 800); // A3

            // measure 29
            jingle.Add(220, 200);  // A3
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);

            // measure 30
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.G4, 100);
            jingle.Add(Tunes.Tone.G4, 100);

            // measure 31
            jingle.Add(Tunes.Tone.A4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.D4, 200);

            // measure 32
            jingle.Add(Tunes.Tone.C4, 400);
            jingle.Add(Tunes.Tone.G4, 400);


            // REPEAT

            // measure 1
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 2
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 3
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.C4, 300);
            jingle.Add(Tunes.Tone.D4, 100);

            // measure 4
            jingle.Add(Tunes.Tone.E4, 800);

            // measure 5
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 300);
            jingle.Add(Tunes.Tone.F4, 100);

            // measure 6
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 100);
            jingle.Add(Tunes.Tone.E4, 100);

            // measure 7
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.D4, 200);
            jingle.Add(Tunes.Tone.E4, 200);

            // measure 8
            jingle.Add(Tunes.Tone.D4, 400);
            jingle.Add(Tunes.Tone.G4, 400);

            // measure 9
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 10
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 400);

            // measure 11
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.C4, 300);
            jingle.Add(Tunes.Tone.D4, 100);

            // measure 12
            jingle.Add(Tunes.Tone.E4, 800);

            // measure 13
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.F4, 300);
            jingle.Add(Tunes.Tone.F4, 100);

            // measure 14
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 200);
            jingle.Add(Tunes.Tone.E4, 100);
            jingle.Add(Tunes.Tone.E4, 100);

            // measure 15
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.G4, 200);
            jingle.Add(Tunes.Tone.F4, 200);
            jingle.Add(Tunes.Tone.D4, 200);

            // measure 16
            jingle.Add(Tunes.Tone.C4, 800);
        }

        private void LoadDeckTheHalls()
        {
            // deck the halls
            // measure 1
            deckTheHalls.Add(Tunes.Tone.C5, 300);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);

            // measure 2
            deckTheHalls.Add(Tunes.Tone.F4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.F4, 200);

            // measure 3
            deckTheHalls.Add(Tunes.Tone.G4, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 100);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);
            deckTheHalls.Add(Tunes.Tone.G4, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 300);
            deckTheHalls.Add(Tunes.Tone.G4, 100);

            // measure 4
            deckTheHalls.Add(Tunes.Tone.F4, 200);
            deckTheHalls.Add(Tunes.Tone.E4, 200);
            deckTheHalls.Add(Tunes.Tone.F4, 400);

            // measure 5
            deckTheHalls.Add(Tunes.Tone.C5, 300);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);

            // measure 6
            deckTheHalls.Add(Tunes.Tone.F4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.F4, 200);

            // measure 7
            deckTheHalls.Add(Tunes.Tone.G4, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 100);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);
            deckTheHalls.Add(Tunes.Tone.G4, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 300);
            deckTheHalls.Add(Tunes.Tone.G4, 100);

            // measure 8
            deckTheHalls.Add(Tunes.Tone.F4, 200);
            deckTheHalls.Add(Tunes.Tone.E4, 200);
            deckTheHalls.Add(Tunes.Tone.F4, 400);

            // measure 9
            deckTheHalls.Add(Tunes.Tone.G4, 300);
            deckTheHalls.Add(Tunes.Tone.A4, 100);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);

            // measure 10
            deckTheHalls.Add(Tunes.Tone.A4, 300);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);
            deckTheHalls.Add(Tunes.Tone.C5, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);

            // measure 11
            deckTheHalls.Add(Tunes.Tone.A4, 100);
            deckTheHalls.Add(Tunes.Tone.B4, 100);
            deckTheHalls.Add(Tunes.Tone.C5, 200);
            deckTheHalls.Add(Tunes.Tone.D5, 100);
            deckTheHalls.Add(Tunes.Tone.E5, 100);
            deckTheHalls.Add(Tunes.Tone.F5, 200);

            // measure 12
            deckTheHalls.Add(Tunes.Tone.E5, 200);
            deckTheHalls.Add(Tunes.Tone.D5, 200);
            deckTheHalls.Add(Tunes.Tone.C5, 400);

            // measure 13
            deckTheHalls.Add(Tunes.Tone.C5, 300);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);

            // measure 14
            deckTheHalls.Add(Tunes.Tone.F4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.F4, 200);

            // measure 15
            deckTheHalls.Add(Tunes.Tone.D5, 100);
            deckTheHalls.Add(Tunes.Tone.D5, 100);
            deckTheHalls.Add(Tunes.Tone.D5, 100);
            deckTheHalls.Add(Tunes.Tone.D5, 100);
            deckTheHalls.Add(Tunes.Tone.C5, 300);
            // Bb4 (or close enough)
            deckTheHalls.Add(466, 100);

            // measure 16
            deckTheHalls.Add(Tunes.Tone.A4, 200);
            deckTheHalls.Add(Tunes.Tone.G4, 200);
            deckTheHalls.Add(Tunes.Tone.F4, 400);

        }

        private void initConnectDisconnectTunes()
        {
            connect.Add(Tunes.Tone.F4, 100);
            connect.Add(Tunes.Tone.A4, 100);
            connect.Add(Tunes.Tone.C5, 100);

            disconnect.Add(Tunes.Tone.C5, 100);
            disconnect.Add(Tunes.Tone.A4, 100);
            disconnect.Add(Tunes.Tone.F4, 100);
        }
    }
}
