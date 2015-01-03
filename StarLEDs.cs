using System;
using Microsoft.SPOT;
using WS2811;
using Microsoft.SPOT.Hardware;
using System.Threading;

namespace SpiderStarTunesBT
{
    class StarLEDs
    {
        WS2811Led MyWS2811Strip;

        public StarLEDs()
        {
            int NumberOfLeds = 32; // Modify here the led number of your strip !

            // Initialize the strip : here using SPI2 and 800Khz model and using the linear human perceived luminosity PWM conversion factor of 2.25
            MyWS2811Strip = new WS2811Led(NumberOfLeds, SPI.SPI_module.SPI1, WS2811Led.WS2811Speed.S800KHZ, 2.25);

            //ringsSolid();

            //rotateLines();

            //rings(1);
        }

        // set up LED arrangement functions:
        void setCenterLED(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(3, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        void setRing1LEDs(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(2, red, green, blue);
            MyWS2811Strip.Set(4, red, green, blue);
            MyWS2811Strip.Set(7, red, green, blue);
            MyWS2811Strip.Set(10, red, green, blue);
            MyWS2811Strip.Set(13, red, green, blue);
            MyWS2811Strip.Set(16, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        void setRing2LEDs(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(1, red, green, blue);
            MyWS2811Strip.Set(5, red, green, blue);
            MyWS2811Strip.Set(8, red, green, blue);
            MyWS2811Strip.Set(11, red, green, blue);
            MyWS2811Strip.Set(14, red, green, blue);
            MyWS2811Strip.Set(17, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        void setRing3LEDs(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(0, red, green, blue);
            MyWS2811Strip.Set(6, red, green, blue);
            MyWS2811Strip.Set(9, red, green, blue);
            MyWS2811Strip.Set(12, red, green, blue);
            MyWS2811Strip.Set(15, red, green, blue);
            MyWS2811Strip.Set(18, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        void setVerticalLEDs(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(0, red, green, blue);
            MyWS2811Strip.Set(1, red, green, blue);
            MyWS2811Strip.Set(2, red, green, blue);
            MyWS2811Strip.Set(3, red, green, blue);
            MyWS2811Strip.Set(4, red, green, blue);
            MyWS2811Strip.Set(5, red, green, blue);
            MyWS2811Strip.Set(6, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        void setSWtoNELEDs(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(3, red, green, blue);
            MyWS2811Strip.Set(7, red, green, blue);
            MyWS2811Strip.Set(8, red, green, blue);
            MyWS2811Strip.Set(9, red, green, blue);
            MyWS2811Strip.Set(13, red, green, blue);
            MyWS2811Strip.Set(14, red, green, blue);
            MyWS2811Strip.Set(15, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        void setNWtoSELEDs(byte red, byte green, byte blue, bool clear = false)
        {
            if (clear)
                MyWS2811Strip.Clear();
            MyWS2811Strip.Set(3, red, green, blue);
            MyWS2811Strip.Set(10, red, green, blue);
            MyWS2811Strip.Set(11, red, green, blue);
            MyWS2811Strip.Set(12, red, green, blue);
            MyWS2811Strip.Set(16, red, green, blue);
            MyWS2811Strip.Set(17, red, green, blue);
            MyWS2811Strip.Set(18, red, green, blue);
            MyWS2811Strip.Transmit();
        }

        public void clear()
        {
            MyWS2811Strip.Clear();
            MyWS2811Strip.Transmit();
        }

        public void fadeInOut()
        {
            for (int i = 0; i < 10; i++)
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;
                byte red = 0;
                byte green = 0;
                byte blue = 0;


                if (i % 2 == 0)
                {
                    green = 255;
                }
                else
                {
                    red = 255;
                }

                // fade in 
                for (double p = 0.05; p < 1; p = p + 0.05)
                {
                    r = (byte)(red * p);
                    g = (byte)(green * p);
                    b = (byte)(blue * p);
                    setCenterLED(r, g, b);
                    setRing1LEDs(r, g, b);
                    setRing2LEDs(r, g, b);
                    setRing3LEDs(r, g, b);

                    Thread.Sleep(50);
                }

                // fade out 
                for (double p = 1; p > 0; p = p - 0.05)
                {
                    r = (byte)(red * p);
                    g = (byte)(green * p);
                    b = (byte)(blue * p);
                    setCenterLED(r, g, b);
                    setRing1LEDs(r, g, b);
                    setRing2LEDs(r, g, b);
                    setRing3LEDs(r, g, b);

                    Thread.Sleep(50);
                }

                clear();

            }
        }

        public void ringsSolid()
        {
            for (int i = 0; i < 12; i++)
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;

                if (i % 2 == 0)
                {
                    g = 255;
                }
                else
                {
                    r = 255;
                }

                setCenterLED(r, g, b);

                Thread.Sleep(250);

                setRing1LEDs(r, g, b);

                Thread.Sleep(250);

                setRing2LEDs(r, g, b);

                Thread.Sleep(250);

                setRing3LEDs(r, g, b);

                Thread.Sleep(250);

                clear();

            }
        }

        public void ringsSolidIn()
        {
            for (int i = 0; i < 12; i++)
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;

                if (i % 2 == 0)
                {
                    g = 255;
                }
                else
                {
                    r = 255;
                }


                setRing3LEDs(r, g, b);

                Thread.Sleep(250);

                setRing2LEDs(r, g, b);

                Thread.Sleep(250);

                setRing1LEDs(r, g, b);

                Thread.Sleep(250);

                setCenterLED(r, g, b);

                Thread.Sleep(250);

                clear();

            }
        }

        public void rotateLines()
        {
            for (int i = 0; i < 12; i++)
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;

                if (i % 2 == 0)
                {
                    g = 255;
                }
                else
                {
                    r = 255;
                }

                setVerticalLEDs(r, g, b, true);

                Thread.Sleep(100);

                setSWtoNELEDs(r, g, b, true);

                Thread.Sleep(100);

                setNWtoSELEDs(r, g, b, true);

                Thread.Sleep(100);

                clear();

            }

            //if (NextPattern > 0)
            //    startNextPattern(NextPattern);
        }

        public void rings()
        {
            for (int i = 0; i < 12; i++)
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;

                if (i % 2 == 0)
                {
                    g = 255;
                }
                else
                {
                    r = 255;
                }

                setCenterLED(r, g, b, true);

                Thread.Sleep(150);

                setRing1LEDs(r, g, b, true);

                Thread.Sleep(150);

                setRing2LEDs(r, g, b, true);

                Thread.Sleep(150);

                setRing3LEDs(r, g, b, true);

                Thread.Sleep(150);

                clear();
            }
        }

        public void ringsIn()
        {
            for (int i = 0; i < 12; i++)
            {
                byte r = 0;
                byte g = 0;
                byte b = 0;

                if (i % 2 == 0)
                {
                    g = 255;
                }
                else
                {
                    r = 255;
                }

                setRing3LEDs(r, g, b, true);

                Thread.Sleep(150);

                setRing2LEDs(r, g, b, true);

                Thread.Sleep(150);

                setRing1LEDs(r, g, b, true);

                Thread.Sleep(150);

                setCenterLED(r, g, b, true);

                Thread.Sleep(150);

                clear();
            }
        }

        private void startNextPattern(int NextPattern)
        {
            //switch (NextPattern)
            //{
            //    case 1:
            //        ringsSolid(2);
            //        break;
            //    case 2:
            //        rotateLines(3);
            //        break;
            //    case 3:
            //        rings(1);
            //        break;
            //}
        }
    }
}
