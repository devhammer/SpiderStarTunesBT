SpiderStarTunesBT
=================

This project came out of a desire to do something fun and interesting to help celebrate Christmas. I'm a huge fan of blinky lights, and during the 2014 black Friday/cyber Monday period, I managed to pick up some WS2812 RGB LED strips at a great price (4 meters worth), so I knew I needed to find a cool project to use them on.

While I initially considered building an LED matrix with the strips, that seemed like a been-there, done-that, kind of project. Instead, I thought of creating a star shape out of acrylic or similar materials, and mounting LED strips on that.

I started with a design created in inkscape, and cut a template made from hardboard (aka masonite), by printing out the design, and using spray adhesive to attach the pattern to the hardboard. I'm glad I took this step, because my original design was too small to fit the number of LEDs I wanted (the main vertical strip has 7 LEDs, with 4 sets of 3 LEDs on the diagonal arms).

Once having finalized the outline of the star, I ordered some white 1/4" sheet PVC from Amazon (relatively cheap, and I could get it quickly), and cut out 3 stars using the pattern. The first, I cut using a jigsaw, and the remaining two I cut on my band saw, and flush-trimmed using a router table.

In terms of materials, the 1/4" PVC turned out to be way thicker than I needed, and the jigsaw and router both tended to chew up the PVC at times, resulting in a rougher outline than I wished. I may have the design laser-cut for a future revision to get a cleaner outline.

To adhere the strips, I simply used double-sided tape. I wired the strips with the ground, 5v, and data in coming in at the bottom of the star, wired through from the back. Power and ground to the remaining strips, I wired at the center of the star, since the strips don't care where the power and ground come from, and I wired the data lines in sequence from bottom right to top right to bottom left to top left, with all of the data in lines towards the center. I'd love to have a cleaner way to wire these, but from a distance the wiring is not really noticeable, particularly if the wire insulation matches the background color of the star base.

Once each given segment was wired, I initially tested the strips using a Pololu A* Micro Arduino-compatible board, using Pololu's WS2812 library. This allowed me to ensure that the strips were working before moving to the next soldering task.

Once having completed assembly of the star and LEDs, I secured the points where the wire went through the PVC with hot glue, and moved on to the Gadgeteer software.

Unlike Arduino boards, you can't simply bit-bang the signal for a WS2812 RGB LED strip with NETMF/Gadgeteer, because you can't really bit-bang that fast with managed code. However, it IS possible to run these strips via SPI, and <a href="https://www.ghielectronics.com/community/user/2604">one of the nice community members</a> on the GHI Forums provided <a href="https://www.ghielectronics.com/community/codeshare/entry/649">a library for doing just that</a>. There's also <a href="https://www.ghielectronics.com/community/codeshare/entry/977">an updated version of the library here</a> that addresses an issue I also ran into.

I'm using the GHI FEZ Spider mainboard, a MakeWire module (3rd party Gadgeteer module that breaks out all the signal wires) to connect the LED strips, a GHI Tunes module (piezo buzzer) for music, and a GHI Bluetooth module for serial communication, and to control the patterns and song playback.

Have questions? Feel free to drop me a note at http://devhammer.net/contact, or file an issue if you find a bug.
