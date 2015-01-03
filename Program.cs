using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation;
using Microsoft.SPOT.Presentation.Controls;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Presentation.Shapes;
using Microsoft.SPOT.Touch;

using Gadgeteer.Networking;
using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace SpiderStarTunesBT
{
    public partial class Program
    {
        // class containing melodies for Tunes module
        Melodies _melodies;

        // class for handling star LEDs
        StarLEDs _starLEDs;

        private Thread _blinkyThread;
        private object syncRoot;

        // Bluetooth connection members
        readonly Bluetooth _bluetooth = new Bluetooth(4);
        Bluetooth.Client _client;
        private Boolean _inPairingMode = false;
        private int _currentBtState = 0;

        // random mode members
        GT.Timer randomModeTimer;
        Random rnd;
        int randomPattern = 0;
        int patternCount = 6;

        // This method is run when the mainboard is powered up or reset.   
        void ProgramStarted()
        {
            _melodies = new Melodies();

            _starLEDs = new StarLEDs();

            _starLEDs.clear();

            InitBluetooth();

            button.ButtonPressed += button_ButtonPressed;
            //tunes.Play(_melodies.connect);

            syncRoot = new Object();

            // random mode
            randomModeTimer = new GT.Timer(1000);
            randomModeTimer.Tick += randomModeTimer_Tick;
            rnd = new Random();
            // start random mode automatically
            randomModeTimer.Start();

            // Use Debug.Print to show messages in Visual Studio's "Output" window during debugging.
            Debug.Print("Program Started");
        }

        void randomModeTimer_Tick(GT.Timer timer)
        {
            if (this._blinkyThread != null && this._blinkyThread.IsAlive)
            {
                // let it run
            }
            else
            {
                randomPattern = rnd.Next(patternCount);

                switch (randomPattern)
                {
                    case 0:
                        sendIfConnected("Starting pattern rotateLines");
                        _blinkyThread = new Thread(new ThreadStart(_starLEDs.rotateLines));
                        break;
                    case 1:
                        sendIfConnected("Starting pattern fadeInOut");
                        _blinkyThread = new Thread(new ThreadStart(_starLEDs.fadeInOut));
                        break;
                    case 2:
                        sendIfConnected("Starting pattern rings");
                        _blinkyThread = new Thread(new ThreadStart(_starLEDs.rings));
                        break;
                    case 3:
                        sendIfConnected("Starting pattern ringsIn");
                        _blinkyThread = new Thread(new ThreadStart(_starLEDs.ringsIn));
                        break;
                    case 4:
                        sendIfConnected("Starting pattern ringsSolid");
                        _blinkyThread = new Thread(new ThreadStart(_starLEDs.ringsSolid));
                        break;
                    case 5:
                        sendIfConnected("Starting pattern ringsSolidIn");
                        _blinkyThread = new Thread(new ThreadStart(_starLEDs.ringsSolidIn));
                        break;
                }

                _blinkyThread.Start();
            }
        }

        void button_ButtonPressed(Button sender, Button.ButtonState state)
        {
            if (!_inPairingMode)
            {
                _client.EnterPairingMode();
            }
            else
            {
                _bluetooth.Reset();
            }
            _inPairingMode = !_inPairingMode;
        }

        private void InitBluetooth()
        {
            _client = _bluetooth.ClientMode;

            _bluetooth.SetDeviceName("RGBStarBT");

            _bluetooth.BluetoothStateChanged += _bluetooth_BluetoothStateChanged;

            _bluetooth.DataReceived += _bluetooth_DataReceived;
        }

        void _bluetooth_DataReceived(Bluetooth sender, string data)
        {
            //Debug.Print("Data received: " + data);

            // first character only for commands
            data = data.Substring(0, 1);

            sendIfConnected("Received: " + data);

            switch (data)
            {
                case "C":
                    sendIfConnected("Playing melody connect");
                    tunes.Play(_melodies.connect);
                    break;
                case "D":
                    sendIfConnected("Playing melody disconnect");
                    tunes.Play(_melodies.disconnect);
                    break;
                case "J":
                    sendIfConnected("Playing Jingle Bells");
                    tunes.Play(_melodies.jingle);
                    break;
                case "H":
                    sendIfConnected("Playing Deck the Halls");
                    tunes.Play(_melodies.deckTheHalls);
                    break;
                case "R": // enable/disable random mode
                    if (!randomModeTimer.IsRunning)
                    {
                        sendIfConnected("Enabling random mode");
                        randomModeTimer.Start();
                    }
                    else
                    {
                        sendIfConnected("Disabling random mode");
                        randomModeTimer.Stop();
                    }
                    break;
                case "0": // clear
                    sendIfConnected("Clearing LEDs");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.clear));
                    _blinkyThread.Start();
                    break;
                case "1": //rings
                    sendIfConnected("Starting pattern rings");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.rings));
                    _blinkyThread.Start();
                    break;
                case "2": //ringsSolid
                    sendIfConnected("Starting pattern ringsSolid");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.ringsSolid));
                    _blinkyThread.Start();
                    break;
                case "3": // rotateLines
                    sendIfConnected("Starting pattern rotateLines");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.rotateLines));
                    _blinkyThread.Start();
                    break;
                case "4": // ringsIn
                    sendIfConnected("Starting pattern ringsIn");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.ringsIn));
                    _blinkyThread.Start();
                    break;
                case "5": // ringsSolidIn
                    sendIfConnected("Starting pattern ringsSolidIn");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.ringsSolidIn));
                    _blinkyThread.Start();
                    break;
                case "6": // fadeInOut
                    sendIfConnected("Starting pattern fadeInOut");
                    if (this._blinkyThread != null && this._blinkyThread.IsAlive)
                        this._blinkyThread.Abort();

                    _blinkyThread = new Thread(new ThreadStart(_starLEDs.fadeInOut));
                    _blinkyThread.Start();
                    break;
            }
        }

        void sendIfConnected(string msg)
        {
            if (_bluetooth.IsConnected)
                _client.Send(msg);
        }
        void _bluetooth_BluetoothStateChanged(Bluetooth sender, Bluetooth.BluetoothState btState)
        {
            Debug.Print("New state:" + btState.ToString());

            if (_currentBtState == 4 && btState == Bluetooth.BluetoothState.Ready)
            {
                tunes.Play(_melodies.disconnect);
            }
            else if (btState == Bluetooth.BluetoothState.Connected)
            {
                tunes.Play(_melodies.connect);
            }

            _currentBtState = (int)btState;
        }
    }
}