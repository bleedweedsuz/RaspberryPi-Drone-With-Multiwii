using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDrone.HUD
{
    class H_V_Bar
    {
        public enum ScrollType
        {
            Vertical,Horizontal
        }
        public enum PointerAlign
        {
            Left,Right,Top,Bottom
        }
        public enum PointerFlow
        {
            UpDown,DownUp,LeftRight,RightLeft
        }
        private int MAXValue, MINValue,CURRENTValue,CurrentPosPointer;
        private ScrollType scrollType;
        private PointerAlign pointerAlign;
        private PointerFlow pointerFlow;
        private Vector2 position;
        private Texture2D Bar_H, Bar_V, Pointer, TestBack;
        private GraphicsDevice graphicsDevice;
        private Rectangle barBox,pointerBox,fontBox;
        private SpriteFont HUD_FONT;
        private String BarName;
        public H_V_Bar(GraphicsDevice graphicsDevice,String BarName,ScrollType scrollType,PointerAlign pointerAlign,PointerFlow pointerFlow, int CURRENTValue,List<Texture2D> IMGLIST,SpriteFont HUD_FONT)
        {
            this.graphicsDevice = graphicsDevice;
            this.scrollType = scrollType;
            this.pointerAlign = pointerAlign;
            this.pointerFlow = pointerFlow;
            this.MAXValue = MAXValue;
            this.MINValue = MINValue;
            this.CURRENTValue = CURRENTValue;
            this.HUD_FONT = HUD_FONT;
            this.BarName = BarName;
            //INIT IMAGE
            Bar_H = IMGLIST[3];//BAR Horizontal
            Bar_V = IMGLIST[4];//BAR Vertical
            Pointer = IMGLIST[1];//Pointer Index
            TestBack = IMGLIST[5];//Test Back
        }
        public void SetCurrentVal(int Value)
        {
            CURRENTValue = Value;
        }
        public void SetMaxMinVal(int MAXValue, int MINValue)
        {
            this.MAXValue = MAXValue;
            this.MINValue = MINValue;
        }
        public void Update(GameTime gameTime)
        {
            int W = graphicsDevice.Viewport.Width, H = graphicsDevice.Viewport.Height;
            switch (scrollType) {
                case ScrollType.Vertical:
                    {
                        #region "VERTICAL BAR"
                        {   //BAR
                            int orgWidth = Bar_V.Width, orgHeight = Bar_V.Height * 2;
                            decimal adjWidth, adjHeight;
                            adjHeight = H / 5;
                            adjWidth = adjHeight * decimal.Divide(orgWidth,orgHeight);
                            barBox = new Rectangle((int)position.X - (int)(adjWidth / 2), (int)position.Y - (int)(adjHeight / 2), (int)adjWidth, (int)adjHeight);
                        }
                        {
                            //Pointer
                            CurrentPosPointer = (int)(decimal.Divide((CURRENTValue - MINValue), (MAXValue - MINValue)) * 100);
                            CurrentPosPointer = (int)(decimal.Divide(barBox.Height, 100) * CurrentPosPointer);
                            int orgWidth = Pointer.Width, orgHeight = Pointer.Height;
                            decimal adjWidth, adjHeight;
                            adjHeight = H / 60;
                            adjWidth = adjHeight * decimal.Divide(orgWidth, orgHeight);

                            if (pointerAlign == PointerAlign.Left)
                            {
                                if (pointerFlow == PointerFlow.UpDown)
                                {
                                    pointerBox = new Rectangle((int)position.X - barBox.Width - (int)(adjWidth / 2), barBox.Y + CurrentPosPointer, (int)adjWidth, (int)adjHeight);
                                }
                                else if (pointerFlow == PointerFlow.DownUp)
                                {
                                    pointerBox = new Rectangle((int)position.X - barBox.Width - (int)(adjWidth / 2), barBox.Y + barBox.Height - CurrentPosPointer, (int)adjWidth, (int)adjHeight);
                                }
                                fontBox = new Rectangle(pointerBox.Left - pointerBox.Width - pointerBox.Width * 4, pointerBox.Top - pointerBox.Height, pointerBox.Width * 4, pointerBox.Height * 2);//Mostly 4 character
                            }
                            else if (pointerAlign == PointerAlign.Right)
                            {
                                if (pointerFlow == PointerFlow.UpDown)
                                {
                                    pointerBox = new Rectangle((int)position.X + barBox.Width + (int)(adjWidth / 2), barBox.Y + CurrentPosPointer, (int)adjWidth, (int)adjHeight);
                                }
                                else if (pointerFlow == PointerFlow.DownUp)
                                {
                                    pointerBox = new Rectangle((int)position.X + barBox.Width + (int)(adjWidth / 2), barBox.Y + barBox.Height - CurrentPosPointer, (int)adjWidth, (int)adjHeight);
                                }
                                fontBox = new Rectangle(pointerBox.Right, pointerBox.Top - pointerBox.Height, pointerBox.Width * 4, pointerBox.Height * 2);//Mostly 4 character
                            }
                        }
                        #endregion
                    } break;
                case ScrollType.Horizontal:
                    {
                        #region "HORIZONTAL BAR"
                        {   //BAR
                            int orgWidth = Bar_H.Width, orgHeight = Bar_H.Height / 2;
                            decimal adjWidth, adjHeight;
                            adjWidth = W / 10;
                            adjHeight = Math.Round(decimal.Divide(adjWidth, decimal.Divide(orgWidth, orgHeight)), 4);
                            barBox = new Rectangle((int)position.X - (int)(adjWidth / 2), (int)position.Y - (int)(adjHeight / 2), (int)adjWidth, (int)adjHeight);
                        }
                        {   //Pointer
                            CurrentPosPointer = (int)(decimal.Divide((CURRENTValue - MINValue), (MAXValue - MINValue)) * 100);
                            CurrentPosPointer = (int)(decimal.Divide(barBox.Width, 100) * CurrentPosPointer);
                            int orgWidth = Pointer.Width, orgHeight = Pointer.Height;
                            decimal adjWidth, adjHeight;
                            adjWidth = W / 200;
                            adjHeight = Math.Round(decimal.Divide(adjWidth, decimal.Divide(orgWidth, orgHeight)), 4);
                            if (pointerAlign == PointerAlign.Top)
                            {
                                if (pointerFlow == PointerFlow.LeftRight)
                                {
                                    pointerBox = new Rectangle(barBox.X + CurrentPosPointer, barBox.Y - barBox.Height, (int)adjWidth, (int)adjHeight);
                                }
                                else if (pointerFlow == PointerFlow.RightLeft)
                                {
                                    pointerBox = new Rectangle(barBox.X + barBox.Width - CurrentPosPointer, barBox.Y - barBox.Height, (int)adjWidth, (int)adjHeight);
                                }
                            }
                            else if (pointerAlign == PointerAlign.Bottom)
                            {
                                if (pointerFlow == PointerFlow.LeftRight)
                                {
                                    pointerBox = new Rectangle(barBox.X + CurrentPosPointer, barBox.Y + barBox.Height + (int)adjHeight, (int)adjWidth, (int)adjHeight);
                                }
                                else if (pointerFlow == PointerFlow.RightLeft)
                                {
                                    pointerBox = new Rectangle(barBox.X + barBox.Width - CurrentPosPointer, barBox.Y + barBox.Height + (int)adjHeight, (int)adjWidth, (int)adjHeight);
                                }
                            }
                        }
                        //Not complete but this will do for now
                        fontBox = new Rectangle(pointerBox.Center.X - pointerBox.Width * 3, pointerBox.Bottom, pointerBox.Width * 5, pointerBox.Height * 3);//Mostly 4 character
                        #endregion
                    } break;
                default: break;
            }
        }
        public void Update_Pos(Vector2 position)
        {
            this.position = position;
        }
        public void Draw(GameTime gameTime,SpriteBatch spriteBatch)
        {
            if (scrollType == ScrollType.Horizontal)
            {
                DrawHorizontalBar(gameTime, spriteBatch);
            }
            else if (scrollType == ScrollType.Vertical)
            {
                DrawVerticalBar(gameTime, spriteBatch);
            }
        }
        private void DrawHorizontalBar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Bar_H, barBox, Color.White);
            Rectangle tempP = new Rectangle(0, 0, Pointer.Width, Pointer.Height);
            if (pointerAlign == PointerAlign.Bottom)
            {
                spriteBatch.Draw(Pointer, pointerBox, tempP, Color.White, MathHelper.ToRadians(180), new Vector2(tempP.Center.X, tempP.Center.Y), SpriteEffects.None, 0);
            }
            else if (pointerAlign == PointerAlign.Top)
            {
                spriteBatch.Draw(Pointer, pointerBox, tempP, Color.White, MathHelper.ToRadians(0), new Vector2(tempP.Center.X, tempP.Center.Y), SpriteEffects.None, 0);
            }
            spriteBatch.Draw(TestBack, fontBox, Color.FromNonPremultiplied(0, 255, 0, 40));
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, HUD_FONT, CURRENTValue.ToString(), fontBox, Color.Black);

            Rectangle rect = new Rectangle(barBox.X + barBox.Width, barBox.Y - (int)HUD_FONT.MeasureString(BarName).Y/2, (int)HUD_FONT.MeasureString(BarName).X, (int)HUD_FONT.MeasureString(BarName).Y);
            spriteBatch.Draw(TestBack, rect, Color.FromNonPremultiplied(0, 255, 0, 40));
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, HUD_FONT, BarName, rect, Color.Black);

        }
        private void DrawVerticalBar(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Bar_V, barBox, Color.White);
            Rectangle tempP = new Rectangle(0, 0, Pointer.Width, Pointer.Height);
            if (pointerAlign == PointerAlign.Left)
            {
                spriteBatch.Draw(Pointer, pointerBox, tempP, Color.White, MathHelper.ToRadians(270), new Vector2(tempP.Center.X, tempP.Center.Y), SpriteEffects.None, 0);
            }
            else if (pointerAlign == PointerAlign.Right)
            {
                spriteBatch.Draw(Pointer, pointerBox, tempP, Color.White, MathHelper.ToRadians(90), new Vector2(tempP.Center.X, tempP.Center.Y), SpriteEffects.None, 0);
            }
            spriteBatch.Draw(TestBack, fontBox, Color.FromNonPremultiplied(0,255,0,40));
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, HUD_FONT, CURRENTValue.ToString(), fontBox, Color.Black);

            Rectangle rect = new Rectangle(barBox.X - (int)HUD_FONT.MeasureString(BarName).X / 2, barBox.Y - (int)HUD_FONT.MeasureString(BarName).Y, (int)HUD_FONT.MeasureString(BarName).X, (int)HUD_FONT.MeasureString(BarName).Y);
            spriteBatch.Draw(TestBack, rect, Color.FromNonPremultiplied(0, 255, 0, 40));
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, HUD_FONT, BarName, rect, Color.Black);
        }
    }
}
