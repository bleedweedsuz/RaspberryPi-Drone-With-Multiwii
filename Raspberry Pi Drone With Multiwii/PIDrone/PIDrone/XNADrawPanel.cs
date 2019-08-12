using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsGraphicsDevice;
using PIDrone.ControlsSets;

namespace PIDrone
{
    class XNADrawPanel : MyLoopControl
    {
        SpriteBatch spriteBatch;
        public SpriteFont HUDfont, QuartzMSFont, ArialFont, BrowalliaNewFont, HaettenschweilerFont;
        private Texture2D boxTexture;
        #region "RENDER COAT"
        public BaseControlStation_TabControls BCS_Controls;
        #endregion
        #region "GENERAL METHODS"
        protected override void Initialize()
        {
            base.Initialize();
            LimitFPS = 60;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            //***************INT CONTENTS******************
            HUDfont = content.Load<SpriteFont>("Fonts/MainFont");
            QuartzMSFont = content.Load<SpriteFont>("Fonts/QuartzMS");
            ArialFont = content.Load<SpriteFont>("Fonts/ArialFont");
            BrowalliaNewFont = content.Load<SpriteFont>("Fonts/BrowalliaNew");
            HaettenschweilerFont = content.Load<SpriteFont>("Fonts/Haettenschweiler");
            boxTexture = content.Load<Texture2D>("Image/GUI/1_HUD/TestBlackSpace");
            //***************INIT RENDER*******************
            BCS_Controls = new BaseControlStation_TabControls(this);
        }
        protected override void Update(GameTime gameTime)
        {
            //FPS DEBUG
            if (IS_GRAPHIC_DEBUG_ON) { GRAPHICS_DEBUGDATA = ""; GRAPHICS_DEBUGDATA = "****GRAPHICS DEBUG****\nFPS:" + CURRENT_FPS; }
            BCS_Controls.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);
            BCS_Controls.Draw(gameTime, spriteBatch);
            //------------------------------------>
            if (IS_GRAPHIC_DEBUG_ON) { _drawStringFormatter(); }
        }
        #endregion
        #region "String Formatter >> DEBUG"
        private void _drawStringFormatter()
        {
            if (GRAPHICS_DEBUGDATA.Equals("")) { return; }
            GraphicsDevice.Viewport = new Viewport(0, 0, this.Width, this.Height);
            //---------->
            int maxWidth = 0, padding = 10, countY=0;
            String TempStr = "";
            foreach(char c in GRAPHICS_DEBUGDATA)
            {
                if (c != '\n')
                {
                    TempStr += c;
                }
                else
                {
                    int tempW = (int)HUDfont.MeasureString(TempStr).X;
                    if(tempW >= maxWidth){
                        maxWidth =tempW;
                    }
                    TempStr = "";
                    countY++;
                }
            }
            Vector2 pos = new Vector2(GraphicsDevice.Viewport.Width - maxWidth - padding,0);
            spriteBatch.Begin();
            spriteBatch.Draw(boxTexture, new Rectangle((int)pos.X, (int)pos.Y, maxWidth, (int)HUDfont.MeasureString(TempStr).Y * countY + padding), Color.FromNonPremultiplied(0, 255, 0, 50));
            spriteBatch.DrawString(HUDfont, GRAPHICS_DEBUGDATA, pos , Color.Black);
            spriteBatch.End();
        }
        public static void DrawStringUsingRectangleBox(SpriteBatch spriteBatch, SpriteFont font, string strToDraw, Rectangle boundaries,Color color)
        {
            Vector2 size = font.MeasureString(strToDraw);

            float xScale = (boundaries.Width / size.X);
            float yScale = (boundaries.Height / size.Y);

            // Taking the smaller scaling value will result in the text always fitting in the boundaires.
            float scale = Math.Min(xScale, yScale);

            // Figure out the location to absolutely-center it in the boundaries rectangle.
            int strWidth = (int)Math.Round(size.X * scale);
            int strHeight = (int)Math.Round(size.Y * scale);
            Vector2 position = new Vector2();
            position.X = (((boundaries.Width - strWidth) / 2) + boundaries.X);
            position.Y = (((boundaries.Height - strHeight) / 2) + boundaries.Y);

            // A bunch of settings where we just want to use reasonable defaults.
            float rotation = 0.0f;
            Vector2 spriteOrigin = new Vector2(0, 0);
            float spriteLayer = 0.0f; // all the way in the front
            SpriteEffects spriteEffects = new SpriteEffects();
            
            // Draw the string to the sprite batch!
            spriteBatch.DrawString(font, strToDraw, position, color, rotation, spriteOrigin, scale, spriteEffects, spriteLayer);
        }
        #endregion
    }
}
