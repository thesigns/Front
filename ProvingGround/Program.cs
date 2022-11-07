using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Front;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace ProvingGround {
    internal class Program {

        private static void Main(string[] args) {

            VideoMode mode = new VideoMode(VideoMode.DesktopMode.Width, VideoMode.DesktopMode.Height);
            ContextSettings contextSettings = new ContextSettings();
            contextSettings.AntialiasingLevel = 8;
            RenderWindow window = new RenderWindow(mode, "Front's Proving Ground", Styles.Fullscreen, contextSettings);
            window.SetVerticalSyncEnabled(true);

            window.Closed += (sender, args) => window.Close();

            while (window.IsOpen) {
                window.DispatchEvents();
                window.Clear(Color.Black);

                window.Display();

                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape)) {
                    window.Close();
                }
            }








        }

    }
}
