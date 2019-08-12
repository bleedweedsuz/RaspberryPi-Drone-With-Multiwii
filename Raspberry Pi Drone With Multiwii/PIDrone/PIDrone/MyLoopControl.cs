using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsGraphicsDevice;

namespace PIDrone
{
    public abstract class MyLoopControl : GraphicsDeviceControl
    {

        float elapseTime; 
        int frameCounter;
        public int CURRENT_FPS;
        public bool IS_GRAPHIC_DEBUG_ON = true;
        public int LimitFPS = 30;
        GameTime _gameTime;
        Stopwatch _timer;
        TimeSpan _elapsed;
        public ContentManager content;
        public string GRAPHICS_DEBUGDATA = "";
        protected override void Initialize()
        {
            _timer = Stopwatch.StartNew();
            content = new ContentManager(Services, "Content");
            Application.Idle += delegate { Invalidate(); };
        }
        protected override void Draw()
        {
            try
            {
                _gameTime = new GameTime(_timer.Elapsed, _timer.Elapsed - _elapsed);
                long ticksPS = 1000 / LimitFPS;
                double startTime = _gameTime.ElapsedGameTime.TotalMilliseconds;
                double sleepTime = 0;
                GameLoop();
                sleepTime = ticksPS - (_gameTime.ElapsedGameTime.TotalMilliseconds - startTime);
                try { if (sleepTime > 0) { Thread.Sleep(Convert.ToInt32(sleepTime)); } else { Thread.Sleep(10); } }
                catch (Exception e) { Console.WriteLine("EX-1:" + e.ToString()); }
            }
            catch(Exception ex)
            {
                Console.WriteLine("EX-2:" + ex.ToString());
            }
        }
        private void GameLoop()
        {
            _elapsed = _timer.Elapsed;
            Update(_gameTime);
            Draw(_gameTime);
            if (IS_GRAPHIC_DEBUG_ON)
            {
                //------------------COUNTER FPS
                elapseTime += (float)_gameTime.ElapsedGameTime.TotalSeconds;
                frameCounter++;
                if (elapseTime > 1)
                {
                    CURRENT_FPS = frameCounter;
                    frameCounter = 0;
                    elapseTime = 0;
                }
            }
        }
        protected abstract void Update(GameTime gameTime);
        protected abstract void Draw(GameTime gameTime);
        protected override void Dispose(bool disposing)
        {
            if (disposing) { content.Unload(); } base.Dispose(disposing);
        }
    }
}