using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIDrone.Camera;
using System.Threading;
using MjpegProcessor;
namespace PIDrone.ControlsSets
{
    class BaseControlStation_TabControls
    {
        #region "GENERAL FIELDS"
        XNADrawPanel xnaDrawPanel;
        ContentManager content;
        //*****************MODEL MAKER****************
        ModelMaker modelMaker_DroneModel;
        //********************************************
        int ViewPortMode = 0,ViewPortModeMax=3,ViewPortModeMin=0;
        public bool ISHUDON = true,ISSTATUSMESSAGEON=true;
        public static Color HUD_GUI_ANGLE_MASK_COLOR = Color.White;
        public float DRONE_ANGLE = 0, DRONE_NAVIGATION_ANGLE = 0, AltiValue = 0, MODEL_Rotation_X = 0, MODEL_Rotation_Y = 0, MODEL_Rotation_Z=0;
        public SpriteFont CSM_Font;
        public TCPCore tcpCore; 
        Thread STATUSCONTROL_THREAD;
        public int AuxMode = 1;// AUX Mode Selection 1, 2, 3, 4
        public MjpegDecoder mJpegDecoder;
        Texture2D MJPG_captureImage;
        #endregion
        #region "CAMERA FIELD"
        ArcBallCamera cam1,cam2,cam3,cam4;
        Viewport defaultViewPort,v1, v2, v3, v4;
        Matrix pM_1, pM_2, pM_3, pM_4;
        #endregion
        #region "INPUT FIELD"
        PlayerIndex pIndex = PlayerIndex.One;
        KeyboardState oldKeyboardState, currentKeyboardState;
        GamePadState oldGamepadState, currentGamePadState;
        #endregion
        #region "IMAGE LIST"
        List<Texture2D> IMAGELIST = new List<Texture2D>();
        #endregion
        #region "BAR"
        HUD.H_V_Bar ThrottleBar, ElevatorBar, RudderBar, AileronBar;
        #endregion
        #region "Static Field"
        public static bool isArmed = false;
        public static int DPad = 0;
        public static float Axes_X_Axis, Axes_Y_Axis, Axes_Trigger_Left,Axes_Trigger_Right,Axes_X_Rotation, Axes_Y_Rotation;
        public static float Axes_X_Axis_Scaled, Axes_Y_Axis_Scaled, Axes_Trigger_Left_Scaled, Axes_Trigger_Right_Scaled, Axes_X_Rotation_Scaled, Axes_Y_Rotation_Scaled,Axes_Trigger_Scaled;
        public static bool Buttons_X = false, Buttons_Y=false, Buttons_A=true, Buttons_B=false, Buttons_RB, Buttons_LB, Buttons_Start, Buttons_Back, Buttons_AnalogBtn1, Buttons_AnalogBtn2;
        public static float MaxThrottle = 2000, MinThrottle=500, MaxRudder=2000, MinRudder=1000, MaxElevator=2000, MinElevator=1000, MaxAileron=2000, MinAileron=1000;
        public static float[] ACKMessage= new float[25]; //Current Length of ACK message is 25

        public static int AUXL = 1200, AUXM = 1500, AUXH = 1800;

        public static string IP_ADDRESS = "127.0.0.1";
        public static int PORT_CONTROL = 8000, PORT_STATUS = 8001, PORT_IMAGE = 8002;

        public static bool isCapture = false;

        #endregion
        #region "GENERAL METHODS"
        public BaseControlStation_TabControls(XNADrawPanel xnaDrawPanel)
        {
            #region "XNA+++"
            this.xnaDrawPanel = xnaDrawPanel;
            this.content = xnaDrawPanel.content;
            #endregion
            //************MODEL MAKER**********
            #region "MODEL INIT"
            modelMaker_DroneModel = new ModelMaker(xnaDrawPanel.GraphicsDevice, content.Load<Model>("Model/DroneFull"));
            #endregion
            #region "IMAGE LIST INIT"
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/AngleBar"));//0
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/Pointer"));//1
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/Back"));//2
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/Bar_H"));//3
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/Bar_V"));//4
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/TestBlackSpace"));//5
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/Navigator"));//6
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/BackTextureNavigation"));//7
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/Nut"));//8
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/NavigatorPin"));//9
            IMAGELIST.Add(content.Load<Texture2D>("Image/GUI/1_HUD/CheckUncheckList"));//10
            #endregion
            #region "FONT INIT"
            CSM_Font = xnaDrawPanel.HaettenschweilerFont;
            #endregion
            #region "CAMERA INIT"
            cam1 = new ArcBallCamera(ArcBallCameraMode.Free); cam1.Target = Vector3.Zero; cam1.Distance = 50;
            cam2 = new ArcBallCamera(ArcBallCameraMode.Free); cam2.Target = Vector3.Zero; cam2.Distance = 50;
            cam3 = new ArcBallCamera(ArcBallCameraMode.Free); cam3.Target = Vector3.Zero; cam3.Distance = 50;
            cam4 = new ArcBallCamera(ArcBallCameraMode.Free); cam4.Target = Vector3.Zero; cam4.Distance = 50;
            #endregion
            #region "H_V BAR INIT"
            ThrottleBar = new HUD.H_V_Bar(xnaDrawPanel.GraphicsDevice,"Throttle",HUD.H_V_Bar.ScrollType.Vertical, HUD.H_V_Bar.PointerAlign.Left,HUD.H_V_Bar.PointerFlow.DownUp , (int)MinThrottle, IMAGELIST,CSM_Font);
            ElevatorBar = new HUD.H_V_Bar(xnaDrawPanel.GraphicsDevice, "Elevator", HUD.H_V_Bar.ScrollType.Vertical, HUD.H_V_Bar.PointerAlign.Right, HUD.H_V_Bar.PointerFlow.DownUp,  (int)MinElevator, IMAGELIST, CSM_Font);
            RudderBar = new HUD.H_V_Bar(xnaDrawPanel.GraphicsDevice, "Rudder", HUD.H_V_Bar.ScrollType.Horizontal, HUD.H_V_Bar.PointerAlign.Bottom, HUD.H_V_Bar.PointerFlow.LeftRight,  (int)MinRudder, IMAGELIST, CSM_Font);
            AileronBar = new HUD.H_V_Bar(xnaDrawPanel.GraphicsDevice, "Aileron", HUD.H_V_Bar.ScrollType.Horizontal, HUD.H_V_Bar.PointerAlign.Bottom, HUD.H_V_Bar.PointerFlow.LeftRight, (int)MinAileron, IMAGELIST, CSM_Font);
            #endregion
            #region "MJPEC DECODER"
            mJpegDecoder = new MjpegDecoder();
            #endregion
        }
        public void Update(GameTime gameTime)
        {
            #region "INPUTS => KEYBOARD & JOYSTICK"
            #region "Keyboard INput"
            oldKeyboardState = Keyboard.GetState();
            currentGamePadState = GamePad.GetState(pIndex);
            //------------------------------------------>
            //Change viewport
            xnaDrawPanel.GRAPHICS_DEBUGDATA += "\nVIEWPORT MODE:" + ViewPortMode + "\nAXES [" + Axes_X_Axis + " " + Axes_Y_Axis + " " + Axes_Trigger_Left + " " + Axes_Trigger_Right + " " + Axes_X_Rotation + " " + Axes_Y_Rotation + "] \nButtons [ " + Buttons_X + " " + Buttons_Y + " " + Buttons_A + " " + Buttons_B + " " + Buttons_RB + " " + Buttons_LB + " \n" + Buttons_Start + " " + Buttons_Back + " " + Buttons_AnalogBtn1 + " " + Buttons_AnalogBtn2 + " ]";//DEBUG
            if ((oldGamepadState.DPad.Right == ButtonState.Pressed && currentGamePadState.DPad.Right == ButtonState.Released))
            {
                ViewPortMode++; if (ViewPortMode > ViewPortModeMax) { ViewPortMode = 0; }
            }
            else if ((oldGamepadState.DPad.Left == ButtonState.Pressed && currentGamePadState.DPad.Left == ButtonState.Released))
            {
                ViewPortMode--; if (ViewPortMode < ViewPortModeMin){ViewPortMode = ViewPortModeMax;}
            }
            if (oldKeyboardState.IsKeyDown(Keys.End) && currentKeyboardState.IsKeyUp(Keys.End))
            {
                if (ISHUDON) { ISHUDON = false; } else { ISHUDON = true; }
            }
          
            #endregion
            //Get Joystick Data
            #region "Buttons For Indicator Only"
            if (currentGamePadState.Buttons.Y == ButtonState.Pressed && oldGamepadState.Buttons.Y == ButtonState.Released) { AuxMode++; if (AuxMode > 4) { AuxMode = 1; } }

            if (currentGamePadState.Buttons.X == ButtonState.Pressed && oldGamepadState.Buttons.X == ButtonState.Released) { if (!Buttons_X) { Buttons_X = true; Buttons_A = false; Buttons_B = false; } }
            if (currentGamePadState.Buttons.A == ButtonState.Pressed && oldGamepadState.Buttons.A == ButtonState.Released) { if (!Buttons_A) { Buttons_A = true; Buttons_X = false; Buttons_B = false; } }
            if (currentGamePadState.Buttons.B == ButtonState.Pressed && oldGamepadState.Buttons.B == ButtonState.Released) { if (!Buttons_B) { Buttons_B = true; Buttons_A = false; Buttons_X = false; } }
            
            if (currentGamePadState.Buttons.RightShoulder == ButtonState.Pressed) { Buttons_RB = true; } else { Buttons_RB = false; }
            if (currentGamePadState.Buttons.LeftShoulder == ButtonState.Pressed) { Buttons_LB = true; } else { Buttons_LB = false; }

            if (currentGamePadState.Buttons.Start == ButtonState.Pressed) { Buttons_Start = true; } else { Buttons_Start = false; }
            if (currentGamePadState.Buttons.Back == ButtonState.Pressed) { Buttons_Back = true; } else { Buttons_Back = false; }

            if (currentGamePadState.Buttons.LeftStick == ButtonState.Pressed) { Buttons_AnalogBtn1 = true; } else { Buttons_AnalogBtn1 = false; }
            if (currentGamePadState.Buttons.RightStick == ButtonState.Pressed) { Buttons_AnalogBtn2 = true; } else { Buttons_AnalogBtn2 = false; }

            if (currentGamePadState.DPad.Up == ButtonState.Pressed) { DPad = 1; } //Up
            else if (currentGamePadState.DPad.Down == ButtonState.Pressed) { DPad = 2; } //Down
            else if (currentGamePadState.DPad.Left == ButtonState.Pressed) { DPad = 3; } //Left
            else if (currentGamePadState.DPad.Right == ButtonState.Pressed) { DPad = 4; } //Right
            else { DPad = 0; }

            #endregion
            #region "Axes Analog Value"
            Axes_X_Axis = currentGamePadState.ThumbSticks.Left.X;
            Axes_Y_Axis = currentGamePadState.ThumbSticks.Left.Y;
            Axes_Trigger_Left = currentGamePadState.Triggers.Left;
            Axes_Trigger_Right = currentGamePadState.Triggers.Right;
            Axes_X_Rotation = currentGamePadState.ThumbSticks.Right.X;
            Axes_Y_Rotation = currentGamePadState.ThumbSticks.Right.Y;
            //Scale Region
            int scaleFactor = 1000,TriggerBalancer = (int)((MaxAileron + MinAileron) /2);
            Axes_X_Axis_Scaled = Utils.map((int)((Axes_X_Axis + 1.0f) * scaleFactor),0,2000,1000,2000);
            Axes_Y_Axis_Scaled = Utils.map((int)((Axes_Y_Axis + 1.0f) * scaleFactor), 0, 2000, (int)MinThrottle, (int)MaxThrottle);//Throttle
            Axes_Trigger_Left_Scaled =  Utils.map((int)(Axes_Trigger_Left * scaleFactor),0,2000,1000,2000);
            Axes_Trigger_Right_Scaled =  Utils.map((int)(Axes_Trigger_Right * scaleFactor),0,2000,1000,2000);
            Axes_X_Rotation_Scaled =  Utils.map((int)((Axes_X_Rotation + 1.0f) * scaleFactor),0,2000,(int)MinRudder,(int)MaxRudder);//Rudder
            Axes_Y_Rotation_Scaled = Utils.map((int)((Axes_Y_Rotation + 1.0f) * scaleFactor), 0, 2000, (int)MinElevator,(int)MaxElevator);//Elevator
            //Trigger
            Axes_Trigger_Scaled = TriggerBalancer + Axes_Trigger_Right_Scaled - Axes_Trigger_Left_Scaled;//Aileron
            #endregion
            #region "JOYSTICK EVENTS"
            if (Axes_Y_Axis_Scaled <= MinThrottle && (oldGamepadState.Buttons.Start == ButtonState.Pressed && currentGamePadState.Buttons.Start == ButtonState.Released)) { 
                if (isArmed) { 
                    isArmed = false;
                    ArmDisArmNazeBoard();
                    DisposeMe();
                } 
                else { 
                    isArmed = true;
                    /*
                    mJpegDecoder.ParseStream(new Uri("http://" + ControlsSets.BaseControlStation_TabControls.IP_ADDRESS +":"+ ControlsSets.BaseControlStation_TabControls.PORT_IMAGE +"/cam.mjpg"));
                    
                     */
                    tcpCore = new TCPCore(IP_ADDRESS,PORT_CONTROL,PORT_STATUS,PORT_IMAGE);
                    
                    STATUSCONTROL_THREAD = new Thread(new ThreadStart(StatusMessage));
                    STATUSCONTROL_THREAD.Start();
                }
            }
            if (oldGamepadState.Buttons.LeftShoulder == ButtonState.Pressed && currentGamePadState.Buttons.LeftShoulder == ButtonState.Released) { if (ISSTATUSMESSAGEON) { ISSTATUSMESSAGEON = false; Console.WriteLine("OK.."); } else { ISSTATUSMESSAGEON = true; Console.WriteLine("off.."); } }
            if (oldGamepadState.Buttons.RightShoulder == ButtonState.Pressed && currentGamePadState.Buttons.RightShoulder == ButtonState.Released) { if (isCapture) { isCapture = false; Console.WriteLine("OK..2"); } else { isCapture = true; Console.WriteLine("off2"); } }
            #endregion
            //------------------------------------------>
            oldGamepadState = currentGamePadState;
            currentKeyboardState = oldKeyboardState;
            #endregion
            #region "VIEWPORT INITLIZE"
            defaultViewPort = xnaDrawPanel.GraphicsDevice.Viewport;
            #endregion
            #region "VIEWPORT REGISTER"
            int Q_W = defaultViewPort.Width / 4, Q_H = defaultViewPort.Height / 3;
           
            Viewport temp_v1 = new Viewport(0, 0, Q_W, Q_H);
            Viewport temp_v2 = new Viewport(0, Q_H, Q_W, Q_H);
            Viewport temp_v3 = new Viewport(0, Q_H * 2, Q_W, Q_H);
            Viewport temp_v4 = new Viewport(Q_W, 0, Q_W * 3, Q_H * 3);
            //--------------------------------------->
            if (ViewPortMode == 0) { v1 = temp_v1; v2 = temp_v2; v3 = temp_v3; v4 = temp_v4; }
            else if (ViewPortMode == 1) { v1 = temp_v2; v2 = temp_v3; v3 = temp_v4; v4 = temp_v1; }
            else if (ViewPortMode == 2) { v1 = temp_v3; v2 = temp_v4; v3 = temp_v1; v4 = temp_v2; }
            else if (ViewPortMode == 3) { v1 = temp_v4; v2 = temp_v1; v3 = temp_v2; v4 = temp_v3; }
            //--------------------------------------->
            pM_1 = Matrix.CreatePerspectiveFieldOfView(ModelMaker.fieldOfViewAngleDegree, v1.AspectRatio , ModelMaker.nearPlaneDistance, ModelMaker.farPlaneDistance);
            pM_2 = Matrix.CreatePerspectiveFieldOfView(ModelMaker.fieldOfViewAngleDegree, v2.AspectRatio, ModelMaker.nearPlaneDistance, ModelMaker.farPlaneDistance);
            pM_3 = Matrix.CreatePerspectiveFieldOfView(ModelMaker.fieldOfViewAngleDegree, v3.AspectRatio, ModelMaker.nearPlaneDistance, ModelMaker.farPlaneDistance);
            pM_4 = Matrix.CreatePerspectiveFieldOfView(ModelMaker.fieldOfViewAngleDegree, v4.AspectRatio, ModelMaker.nearPlaneDistance, ModelMaker.farPlaneDistance);
            #endregion
            #region "Model Update"
            modelMaker_DroneModel.setRotation(MODEL_Rotation_X, MODEL_Rotation_Y, MODEL_Rotation_Z);
            modelMaker_DroneModel.Update(gameTime);
            #endregion
            #region "BAR"
            //Throttle bar
            ThrottleBar.SetMaxMinVal((int)MaxThrottle, (int)MinThrottle);
            ThrottleBar.Update_Pos(new Vector2(xnaDrawPanel.GraphicsDevice.Viewport.Width / 12, xnaDrawPanel.GraphicsDevice.Viewport.Height / 2));
            ThrottleBar.SetCurrentVal((int)Axes_Y_Axis_Scaled);
            ThrottleBar.Update(gameTime);
            //Elevator Bar
            ElevatorBar.SetMaxMinVal((int)MaxElevator, (int)MinElevator);
            ElevatorBar.Update_Pos(new Vector2(xnaDrawPanel.GraphicsDevice.Viewport.Width / 6, xnaDrawPanel.GraphicsDevice.Viewport.Height / 2));
            ElevatorBar.SetCurrentVal((int)Axes_Y_Rotation_Scaled);
            ElevatorBar.Update(gameTime);
            //Rudder Bar
            RudderBar.SetMaxMinVal((int)MaxRudder, (int)MinRudder);
            RudderBar.Update_Pos(new Vector2(xnaDrawPanel.GraphicsDevice.Viewport.Width / 8, xnaDrawPanel.GraphicsDevice.Viewport.Height / 2 + (xnaDrawPanel.GraphicsDevice.Viewport.Height / 6)));
            RudderBar.SetCurrentVal((int)Axes_X_Rotation_Scaled);
            RudderBar.Update(gameTime);
            //Aileron Bar
            AileronBar.SetMaxMinVal((int)MaxAileron, (int)MinAileron);
            AileronBar.Update_Pos(new Vector2(xnaDrawPanel.GraphicsDevice.Viewport.Width / 8, xnaDrawPanel.GraphicsDevice.Viewport.Height / 2 + (xnaDrawPanel.GraphicsDevice.Viewport.Height / 4)));
            AileronBar.SetCurrentVal((int)Axes_Trigger_Scaled);
            AileronBar.Update(gameTime); 
            #endregion
            #region UDPMessage
            TCPMessageSystemSync(gameTime);
            #endregion
            #region "MJPG UPDATE CONTROLLER"
            if (isArmed)
            {
                try
                {
                    if (isCapture)
                    {
                        MJPG_captureImage = mJpegDecoder.GetMjpegFrame(xnaDrawPanel.GraphicsDevice);
                    }
                }
                catch (System.Net.WebException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            #endregion
        }
        public void Draw(GameTime gameTime,SpriteBatch spriteBatch)
        {
            #region "Draw REGION"
            //REGION 1
            DrawRegion_1(gameTime, spriteBatch);
            //REGION 2
            DrawRegion_2(gameTime, spriteBatch);
            //REGION 3
            DrawRegion_3(gameTime, spriteBatch);
            //REGION 4
            DrawRegion_4(gameTime, spriteBatch);
            #endregion
        }
        public void DisposeMe()
        {
            try { STATUSCONTROL_THREAD.Abort(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); } 
            try { tcpCore.Destroy(); }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        #endregion
        #region "REGION 1"
        /// <summary>
        /// Fetch data from barometer sensor from NAZE FULL AFRO FLIGHT
        /// </summary>
        private void DrawRegion_1(GameTime gameTime, SpriteBatch spriteBatch)
        {
            #region "REGION 1 ALTIMETER AKA ALTITUDE METER"
            xnaDrawPanel.GraphicsDevice.Viewport = v1;
            //********************HUD********************
            int W = xnaDrawPanel.GraphicsDevice.Viewport.Width, H = xnaDrawPanel.GraphicsDevice.Viewport.Height;
            //********************HUD********************
            spriteBatch.Begin();
            //Base Background Image
            int pointer_X = (W / 2) - (H / 2), pointer_Y = 4, adjWidth = H - 4, adjHeight = H - 8;
            spriteBatch.Draw(IMAGELIST[7], new Rectangle(0, 0, W, H), Color.Purple);
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, xnaDrawPanel.QuartzMSFont, Math.Round(AltiValue,2).ToString() + "  FT", new Rectangle(pointer_X, pointer_Y, H, H), Color.White);
            spriteBatch.DrawString(xnaDrawPanel.HUDfont, "A-Meter 1", new Vector2(2, 0), Color.White);
            spriteBatch.End();
            #endregion
        }
        #endregion
        #region "REGION 2"
        /// <summary>
        /// Fetch data from magneto meter sensor from NAZE FULL AFRO FLIGHT
        /// </summary>
        private void DrawRegion_2(GameTime gameTime, SpriteBatch spriteBatch)
        {
            #region "REGION 2 AKA MAGNETO METER"
            xnaDrawPanel.GraphicsDevice.Viewport = v2;
            int W = xnaDrawPanel.GraphicsDevice.Viewport.Width, H = xnaDrawPanel.GraphicsDevice.Viewport.Height;
            //********************HUD********************
            spriteBatch.Begin();
            //Base Background Image
            {
                int pointer_X = (W / 2) - (H / 2), pointer_Y = 4, adjWidth = H - 4, adjHeight = H - 8;
                spriteBatch.Draw(IMAGELIST[7], new Rectangle(0, 0, W, H), Color.White);
                spriteBatch.Draw(IMAGELIST[6], new Rectangle(pointer_X, pointer_Y, adjWidth, adjHeight), HUD_GUI_ANGLE_MASK_COLOR);
                #region "Draw Nuts"
                //Nuts
                {
                    int padding = H / 20;
                    int scaled_WH = H / 10;
                    spriteBatch.Draw(IMAGELIST[8], new Rectangle(pointer_X - scaled_WH / 2, padding, scaled_WH, scaled_WH), Color.White);
                    spriteBatch.Draw(IMAGELIST[8], new Rectangle(pointer_X + adjWidth , padding, scaled_WH, scaled_WH), Color.White);
                    spriteBatch.Draw(IMAGELIST[8], new Rectangle(pointer_X + adjWidth, H - padding - scaled_WH, scaled_WH, scaled_WH), Color.White);
                    spriteBatch.Draw(IMAGELIST[8], new Rectangle(pointer_X - scaled_WH / 2, H - padding - scaled_WH, scaled_WH, scaled_WH), Color.White);
                }
                #endregion
            }
            //Navigation PIN
            {
                int pointer_X = (W / 2), pointer_Y =  H/2, adjWidth = H - 4, adjHeight = H - 8;
                Vector2 centerPivot = new Vector2((float)IMAGELIST[9].Width / 2, (float)IMAGELIST[9].Height / 2);
                
                spriteBatch.Draw(IMAGELIST[9], new Rectangle(pointer_X, pointer_Y, adjWidth, adjHeight), 
                    new Rectangle(0, 0, IMAGELIST[9].Width, IMAGELIST[9].Height), Color.White,
                    MathHelper.ToRadians(DRONE_NAVIGATION_ANGLE),centerPivot, SpriteEffects.None, 1f);
            }
            //Title
            spriteBatch.DrawString(xnaDrawPanel.HUDfont, "M-METER 2", new Vector2(2, 0), Color.White);
            spriteBatch.End();
            #endregion
        }
        #endregion
        #region "REGION 3"
        /// <summary>
        /// Fetch Accelerometer data from sensor and draw model accordingly.
        /// </summary>
        private void DrawRegion_3(GameTime gameTime, SpriteBatch spriteBatch)
        {
            #region "REGION 3 ATTITUTE METER >> 3D MODEL"
            xnaDrawPanel.GraphicsDevice.Viewport = v3;
            //********************MODEL********************
            modelMaker_DroneModel.DrawScene(gameTime, cam3.ViewMatrix, pM_3);
            //********************HUD********************
            spriteBatch.Begin();
            spriteBatch.DrawString(xnaDrawPanel.HUDfont, "3d MODEL 3", new Vector2(0, 0), Color.Black);
            spriteBatch.End();
            #endregion
        }
        #endregion
        #region "REGION 4"
        /// <summary>
        /// CAPTURE ALL SENSOR DATA AND DRAW MAIN HUD
        /// </summary>
        private void DrawRegion_4(GameTime gameTime, SpriteBatch spriteBatch)
        {
            #region "REGION 4 MAIN FEEDBACK"
            xnaDrawPanel.GraphicsDevice.Viewport = v4;
            //********************HUD********************          
            spriteBatch.Begin();

            //Draw Capture Image
            DrawCaptureImage(gameTime, spriteBatch);
            //HUD TITLE
            spriteBatch.DrawString(xnaDrawPanel.HUDfont, "MAIN HUD 4", new Vector2(0, 0), Color.Black);
            //ARMED SIGN
            String armString = "NOT ARMED";
            if (isArmed) { armString = "ARMED"; if (tcpCore != null) { armString += tcpCore.ConnectionStatus; } }
            Rectangle aRect = new Rectangle(0, v4.Height - (v4.Height/20), v4.Width, v4.Height / 20);
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, xnaDrawPanel.ArialFont, armString, aRect, Color.DarkRed);
            spriteBatch.Draw(IMAGELIST[5], aRect, Color.FromNonPremultiplied(10, 255, 10, 20));

            String camString = "Cam Off";
            if (isCapture) { camString = "Cam On"; }
            Rectangle bRect = new Rectangle(0, 0, v4.Width, v4.Height / 20);
            XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, xnaDrawPanel.ArialFont, camString, bRect, Color.DarkRed);
            spriteBatch.Draw(IMAGELIST[5], bRect, Color.FromNonPremultiplied(10, 255, 10, 20));

            if (ISHUDON)
            {
                DrawRollHUD(gameTime, spriteBatch);
                DrawAuxHUD(gameTime, spriteBatch);
                ThrottleBar.Draw(gameTime, spriteBatch);
                ElevatorBar.Draw(gameTime, spriteBatch);
                RudderBar.Draw(gameTime, spriteBatch);
                AileronBar.Draw(gameTime, spriteBatch);
            }
            spriteBatch.End();
            #endregion
        }
        private void DrawRollHUD(GameTime gameTime,SpriteBatch spriteBatch)
        {
            int W = xnaDrawPanel.GraphicsDevice.Viewport.Width, H = xnaDrawPanel.GraphicsDevice.Viewport.Height;
            //ALGLE BAR -------------------->
            int ref_anglebar_adjWidth, ref_anglebar_adjHeight;
            {
                //DRONE_ANGLE += 1;//FROM ANGLE
                //original width ,height
                int orgWidth = IMAGELIST[0].Width, orgHeight = IMAGELIST[0].Height;
                decimal adjWidthAngle, adjHeightAngle;
                adjWidthAngle = W / 4;
                adjHeightAngle = Math.Round(decimal.Divide(adjWidthAngle, decimal.Divide(orgWidth, orgHeight)), 4);
                //Position
                int angle_X, angle_Y;
                angle_X = (int)((W / 2));
                angle_Y = (H / 2);
                Vector2 centerPivot = new Vector2((float)orgWidth / 2, (float)orgHeight / 2);

                ref_anglebar_adjWidth = (int)adjWidthAngle; ref_anglebar_adjHeight = (int)adjHeightAngle;

                spriteBatch.Draw(IMAGELIST[0], new Rectangle(angle_X, angle_Y, (int)adjWidthAngle, (int)adjHeightAngle), new Rectangle(0, 0, orgWidth, orgHeight), HUD_GUI_ANGLE_MASK_COLOR, MathHelper.ToRadians(DRONE_ANGLE), centerPivot, SpriteEffects.None, 1);
            }
            //POINTER
            {
                int orgWidth = IMAGELIST[1].Width, orgHeight = IMAGELIST[1].Height;
                decimal adjWidthPointer, adjHeightPointer;
                adjWidthPointer = W / 60;
                adjHeightPointer = Math.Round(decimal.Divide(adjWidthPointer, decimal.Divide(orgWidth, orgHeight)), 4);

                int pointer_X, pointer_Y;
                pointer_X = (W/2) - ((int)adjWidthPointer /2);
                pointer_Y = (H / 2) - ((int)adjHeightPointer) - (ref_anglebar_adjHeight/2);
                spriteBatch.Draw(IMAGELIST[1], new Rectangle(pointer_X, pointer_Y, (int)adjWidthPointer, (int)adjHeightPointer), HUD_GUI_ANGLE_MASK_COLOR);

                Rectangle fontBox = new Rectangle(pointer_X + (int) adjWidthPointer , pointer_Y, DRONE_ANGLE.ToString().Length * (int)adjWidthPointer ,(int)adjHeightPointer);
                spriteBatch.Draw(IMAGELIST[5], fontBox, Color.FromNonPremultiplied(0, 255, 0, 40));
                XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, CSM_Font, DRONE_ANGLE.ToString() + ".d", fontBox, Color.Black);
            }
        }
        private void DrawAuxHUD(GameTime gameTime, SpriteBatch spriteBatch)
        {
            int X = xnaDrawPanel.GraphicsDevice.Viewport.Width - xnaDrawPanel.GraphicsDevice.Viewport.Width /4;
            int Y = xnaDrawPanel.GraphicsDevice.Viewport.Height/2 - xnaDrawPanel.GraphicsDevice.Viewport.Height/8;

            int boxWidth = xnaDrawPanel.GraphicsDevice.Viewport.Width / 40;
            int boxHeight = boxWidth;

            int marginBelow = xnaDrawPanel.GraphicsDevice.Viewport.Height / 60;

            for (int i = 0; i < 4; i++)
            {
                Rectangle rect = new Rectangle(X, Y + (i * (boxHeight + marginBelow) ), boxWidth, boxHeight);
                Rectangle rectString = new Rectangle(rect.X + rect.Width + 10, rect.Y - rect.Height/2, rect.Width * 3, rect.Height*2);
                Rectangle rectCheck = new Rectangle(0,0,64,64), rectUnCheck = new Rectangle(64,0,64,64), rectList=new Rectangle(128,0,64,64);

                String label = "";
                if (Buttons_X == true && i == 1)
                {
                    spriteBatch.Draw(IMAGELIST[10], rect,rectCheck , Color.FromNonPremultiplied(0,255,0,130));
                }
                else if (Buttons_A == true && i == 2)
                {
                    spriteBatch.Draw(IMAGELIST[10], rect, rectCheck, Color.FromNonPremultiplied(0, 255, 0, 130));
                }
                else if (Buttons_B == true && i == 3)
                {
                    spriteBatch.Draw(IMAGELIST[10], rect, rectCheck, Color.FromNonPremultiplied(0, 255, 0, 130));
                }
                else
                {
                    if (i == 0)
                    {
                        if (AuxMode == 1) { spriteBatch.Draw(IMAGELIST[10], rect, rectList, Color.FromNonPremultiplied(0, 0, 255, 130)); }
                        else if (AuxMode == 2) { spriteBatch.Draw(IMAGELIST[10], rect, rectList, Color.FromNonPremultiplied(0, 255, 0, 130)); }
                        else if (AuxMode == 3) { spriteBatch.Draw(IMAGELIST[10], rect, rectList, Color.FromNonPremultiplied(255, 0, 0, 130)); }
                        else if (AuxMode == 4) { spriteBatch.Draw(IMAGELIST[10], rect, rectList, Color.FromNonPremultiplied(255, 255, 0, 130)); }
                    }
                    else
                    {
                        spriteBatch.Draw(IMAGELIST[10], rect, rectUnCheck, Color.FromNonPremultiplied(255, 0, 0, 130));
                    }
                }
                if (i == 0) { label = "AUX { " + AuxMode + " } [Y]"; } else if (i == 1) { label = "In { " + AUXL + " } [X]"; } else if (i == 2) { label = "In { " + AUXM + " } [A]"; } else if (i == 3) { label = "In { " + AUXH + " } [B]"; }
                XNADrawPanel.DrawStringUsingRectangleBox(spriteBatch, xnaDrawPanel.ArialFont,label, rectString, Color.FromNonPremultiplied(255,255,255,150));
            }
        }
        private void DrawCaptureImage(GameTime gameTime, SpriteBatch spriteBatch)
        {
            int W = xnaDrawPanel.GraphicsDevice.Viewport.Width, H = xnaDrawPanel.GraphicsDevice.Viewport.Height;
            if (isArmed)
            {
                try
                {
                    if (MJPG_captureImage != null)
                    {
                        spriteBatch.Draw(MJPG_captureImage, new Rectangle(0, 0, W, H), Color.White);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                spriteBatch.Draw(IMAGELIST[2], new Rectangle(0, 0, W, H), Color.FromNonPremultiplied(255,255,255,150));
            }
        }
        #endregion
        #region "TCP Message Factory System"
        //This System Use Threading To Send Async Data
        float OT, OR, OE, OA;
        bool ObtnA, ObtnB, ObtnX, ObtnY;
        String UDPMESSAGE_SUFFIX_CONTROLMESSAGE_ARM = "CA", UDPMESSAGE_SUFFIX_CONTROLMESSAGE_DISARM = "CD", UDPMESSAGE_SUFFIX_CONTROLMESSAGE_MULTIPLEMESSAGE ="CM";
        String UDPMESSAGE_SUFFIX_STATUSMESSAGE = "S";
        //String UDPMESSAGE_SUFFIX_IMAGEMESSAGE_ARM = "I";
        bool oldArmState = false;
        //Int64 oldTime = 0; int CountSendFrame = 0;
        public void TCPMessageSystemSync(GameTime gameTime)
        {
            ControlMessage();
        }
        void ControlMessage()
        {
            ArmDisArmNazeBoard();
            #region "CONTROL MULTIPLE MESSAGE SYSTEM AUTO DETECT"
            if (isArmed)
            {
                float Throttle, Rudder, Elevator, Aileron;
                Throttle = Axes_Y_Axis_Scaled; Rudder = Axes_X_Rotation_Scaled; Elevator = Axes_Y_Rotation_Scaled; Aileron = Axes_Trigger_Scaled;
                bool btnA = Buttons_A, btnB = Buttons_B, btnX = Buttons_X, btnY = Buttons_Y;
                if (OT != Throttle || OR != Rudder || OE != Elevator || OA != Aileron || ObtnA != btnA || ObtnB != btnB || ObtnX != btnX || ObtnY != btnY)
                {
                        String Message = UDPMESSAGE_SUFFIX_CONTROLMESSAGE_MULTIPLEMESSAGE; //START WITH MULTIPLE MESSAGE SUFFIX
                        Message += Aileron + ",";//Aileron -> Roll Left Right //ROLL
                        Message += Elevator + ",";//Elevator -> Up Down //PITCH
                        Message += Rudder + ",";//Rudder -> LEft Right //YAW
                        Message += Throttle + ",";//Throttle
                        Message += AUXCONVERTER(1).ToString() + ",";//AUX1
                        Message += AUXCONVERTER(2).ToString() + ",";//AUX2
                        Message += AUXCONVERTER(3).ToString() + ",";//AUX3
                        Message += AUXCONVERTER(4).ToString();//AUX4
                        //TCP MESSAGE SYSTEM
                        tcpCore.Write(tcpCore.ControlStream, Message);
                        //OLD VALUE HOLDER [it need to be change when the message is send]
                        OT = Throttle;
                        OR = Rudder;
                        OE = Elevator;
                        OA = Aileron;
                        ObtnA = btnA;
                        ObtnB = btnB;
                        ObtnX = btnX;
                        ObtnY = btnY;
                }
            }
            #endregion
        }
        private void StatusMessage()
        {
            while(isArmed)
            {
                try
                {
                    if (tcpCore != null)
                    {
                        String Message = UDPMESSAGE_SUFFIX_STATUSMESSAGE;
                        tcpCore.Write(tcpCore.StatusStream, Message);
                        MappingAckMessageInSystemGraphics(tcpCore.Read(tcpCore.StatusStream));
                        Thread.Sleep(100);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        #region "NAZE UTILS RECORDER"
        private void ArmDisArmNazeBoard()
        {
            #region "Arm DisArm Message SYSTEM AUTON DETECT"
            if (oldArmState != isArmed)
            {
                String Message = "";
                //Send The Message
                if (isArmed)
                {
                    Message += UDPMESSAGE_SUFFIX_CONTROLMESSAGE_ARM;
                }
                else
                {
                    Message += UDPMESSAGE_SUFFIX_CONTROLMESSAGE_DISARM;
                }
                tcpCore.Write(tcpCore.ControlStream, Message);
                oldArmState = isArmed;
            }
            #endregion
        }
        private int AUXCONVERTER(int AUXNO)
        {
            int val = AUXL;
            if (AuxMode == AUXNO){if (Buttons_X) { return AUXL; } else if (Buttons_A) { return AUXM; } else if(Buttons_B) { return AUXH;}}
            return val;
        }
        private void MappingAckMessageInSystemGraphics(String AckMessageString)
        {
            String[] temp = AckMessageString.Split(',');
            for (int i = 0; i < temp.Length; i++)
            {
                ACKMessage[i] = float.Parse(temp[i]);
            }
            //DRONE ANGLE
            DRONE_ANGLE = ACKMessage[Utils.MWII_ANGLEX];
            //MODEL ROTATION
            MODEL_Rotation_X = ACKMessage[Utils.MWII_ANGLEX];
            MODEL_Rotation_Y = ACKMessage[Utils.MWII_ANGLEY];
            MODEL_Rotation_Z = ACKMessage[Utils.MWII_HEADING];
            //Altitude Value
            AltiValue = ACKMessage[Utils.MWII_ALTITUDE] / 100;
            //Navigation Angle Degree creation
            DRONE_NAVIGATION_ANGLE = (int)MathHelper.ToDegrees((float)Math.Atan2(MODEL_Rotation_Y, MODEL_Rotation_X));
        }
        #endregion
        #endregion
    }
}