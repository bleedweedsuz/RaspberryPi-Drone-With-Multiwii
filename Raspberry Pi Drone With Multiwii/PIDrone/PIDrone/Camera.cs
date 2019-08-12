using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
  
namespace PIDrone
{
    namespace Camera
    {
        public enum ArcBallCameraMode
        {
            Free = 0,
            RollConstrained = 1
        }
        public class ArcBallCamera
        {
            public static float ReadKeyboardAxis(KeyboardState keyState, Keys downKey, Keys upKey)
            {
                float value = 0;

                if (keyState.IsKeyDown(downKey))
                    value -= 1.0f;

                if (keyState.IsKeyDown(upKey))
                    value += 1.0f;

                return value;
            }
            private Vector3 targetValue;
            private float distanceValue;
            private Quaternion orientation;
            private float inputDistanceRateValue;
            private const float InputTurnRate = 3.0f;
            private ArcBallCameraMode mode;
            private float yaw, pitch;
            public ArcBallCamera(ArcBallCameraMode controlMode)
            {
                orientation = Quaternion.CreateFromAxisAngle(Vector3.Up, MathHelper.Pi);
                mode = controlMode;
                inputDistanceRateValue = 4.0f;
                yaw = MathHelper.Pi;
                pitch = 0;
            }
            public Vector3 Direction
            {
                get
                {
                    Vector3 dir = Vector3.Zero;
                    dir.X = -2.0f *
                        ((orientation.X * orientation.Z) + (orientation.W * orientation.Y));
                    dir.Y = 2.0f *
                        ((orientation.W * orientation.X) - (orientation.Y * orientation.Z));
                    dir.Z =
                        ((orientation.X * orientation.X) + (orientation.Y * orientation.Y)) -
                        ((orientation.Z * orientation.Z) + (orientation.W * orientation.W));
                    Vector3.Normalize(ref dir, out dir);
                    return dir;
                }
            }
            public Vector3 Right
            {
                get
                {
                    Vector3 right = Vector3.Zero;
                    right.X =
                        ((orientation.X * orientation.X) + (orientation.W * orientation.W)) -
                        ((orientation.Z * orientation.Z) + (orientation.Y * orientation.Y));
                    right.Y = 2.0f *
                        ((orientation.X * orientation.Y) + (orientation.Z * orientation.W));
                    right.Z = 2.0f *
                        ((orientation.X * orientation.Z) - (orientation.Y * orientation.W));
                    return right;
                }
            }
            public Vector3 Up
            {
                get
                {
                    Vector3 up = Vector3.Zero;
                    up.X = 2.0f *
                        ((orientation.X * orientation.Y) - (orientation.Z * orientation.W));
                    up.Y =
                        ((orientation.Y * orientation.Y) + (orientation.W * orientation.W)) -
                        ((orientation.Z * orientation.Z) + (orientation.X * orientation.X));
                    up.Z = 2.0f *
                        ((orientation.Y * orientation.Z) + (orientation.X * orientation.W));
                    return up;
                }
            }
            public Matrix ViewMatrix
            {
                get
                {
                    return Matrix.CreateLookAt(targetValue -
                        (Direction * distanceValue), targetValue, Up);
                }
            }
            public ArcBallCameraMode ControlMode
            {
                get { return mode; }
                set
                {
                    if (value != mode)
                    {
                        mode = value;
                        SetCamera(targetValue - (Direction * distanceValue),
                                  targetValue, Vector3.Up);
                    }
                }
            }
            public Vector3 Target
            {
                get
                { return targetValue; }
                set
                { targetValue = value; }
            }
            public float Distance
            {
                get
                { return distanceValue; }
                set
                { distanceValue = value; }
            }
            public float InputDistanceRate
            {
                get
                { return inputDistanceRateValue; }
                set
                { inputDistanceRateValue = value; }
            }
            public Vector3 Position
            {
                get
                {
                    return targetValue - (Direction * Distance);
                }
                set
                {
                    SetCamera(value, targetValue, Vector3.Up);
                }
            }
            public void OrbitUp(float angle)
            {

                switch (mode)
                {
                    case ArcBallCameraMode.Free:
                        //rotate the aspect by the angle 
                        orientation = orientation *
                         Quaternion.CreateFromAxisAngle(Vector3.Right, -angle);

                        //normalize to reduce errors
                        Quaternion.Normalize(ref orientation, out orientation);
                        break;
                    case ArcBallCameraMode.RollConstrained:
                        //update the yaw
                        pitch -= angle;

                        //constrain pitch to vertical to avoid confusion
                        pitch = MathHelper.Clamp(pitch, -(MathHelper.PiOver2) + .0001f,
                            (MathHelper.PiOver2) - .0001f);

                        //create a new aspect based on pitch and yaw
                        orientation = Quaternion.CreateFromAxisAngle(Vector3.Up, -yaw) *
                            Quaternion.CreateFromAxisAngle(Vector3.Right, pitch);
                        break;
                }
            }
            public void OrbitRight(float angle)
            {
                switch (mode)
                {
                    case ArcBallCameraMode.Free:
                        //rotate the aspect by the angle 
                        orientation = orientation *
                            Quaternion.CreateFromAxisAngle(Vector3.Up, angle);

                        //normalize to reduce errors
                        Quaternion.Normalize(ref orientation, out orientation);
                        break;
                    case ArcBallCameraMode.RollConstrained:
                        //update the yaw
                        yaw -= angle;

                        //float mod yaw to avoid eventual precision errors
                        //as we move away from 0
                        yaw = yaw % MathHelper.TwoPi;

                        //create a new aspect based on pitch and yaw
                        orientation = Quaternion.CreateFromAxisAngle(Vector3.Up, -yaw) *
                            Quaternion.CreateFromAxisAngle(Vector3.Right, pitch);

                        //normalize to reduce errors
                        Quaternion.Normalize(ref orientation, out orientation);
                        break;
                }
            }
            public void RotateClockwise(float angle)
            {


                switch (mode)
                {
                    case ArcBallCameraMode.Free:
                        //rotate the orientation around the direction vector
                        orientation = orientation *
                            Quaternion.CreateFromAxisAngle(Vector3.Forward, angle);
                        Quaternion.Normalize(ref orientation, out orientation);
                        break;
                    case ArcBallCameraMode.RollConstrained:
                        //Do nothing, we don't want to roll at all to stay consistent
                        break;
                }
            }
            public void SetCamera(Vector3 position, Vector3 target, Vector3 up)
            {
                //Create a look at matrix, to simplify matters a bit
                Matrix temp = Matrix.CreateLookAt(position, target, up);

                //invert the matrix, since we're determining the
                //orientation from the rotation matrix in RH coords
                temp = Matrix.Invert(temp);

                //set the postion
                targetValue = target;

                //create the new aspect from the look-at matrix
                orientation = Quaternion.CreateFromRotationMatrix(temp);

                //When setting a new eye-view direction 
                //in one of the gimble-locked modes, the yaw and
                //pitch gimble must be calculated.
                if (mode != ArcBallCameraMode.Free)
                {
                    //first, get the direction projected on the x/z plne
                    Vector3 dir = Direction;
                    dir.Y = 0;
                    if (dir.Length() == 0f)
                    {
                        dir = Vector3.Forward;
                    }
                    dir.Normalize();

                    //find the yaw of the direction on the x/z plane
                    //and use the sign of the x-component since we have 360 degrees
                    //of freedom
                    yaw = (float)(Math.Acos(-dir.Z) * Math.Sign(dir.X));

                    //Get the pitch from the angle formed by the Up vector and the 
                    //the forward direction, then subtracting Pi / 2, since 
                    //we pitch is zero at Forward, not Up.
                    pitch = (float)-(Math.Acos(Vector3.Dot(Vector3.Up, Direction))
                        - MathHelper.PiOver2);
                }
            }
            public void HandleDefaultKeyboardControls(KeyboardState kbState,GameTime gameTime)
            {
                if (gameTime == null)
                {
                    throw new ArgumentNullException("gameTime",
                        "GameTime parameter cannot be null.");
                }

                float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

                float dX = elapsedTime * ReadKeyboardAxis(
                    kbState, Keys.A, Keys.D) * InputTurnRate;
                float dY = elapsedTime * ReadKeyboardAxis(
                    kbState, Keys.S, Keys.W) * InputTurnRate;

                if (dY != 0) OrbitUp(dY);
                if (dX != 0) OrbitRight(dX);


                distanceValue += ReadKeyboardAxis(kbState, Keys.Z, Keys.X)
                    * inputDistanceRateValue * elapsedTime;
                if (distanceValue < .001f) distanceValue = .001f;

                if (mode != ArcBallCameraMode.Free)
                {
                    float dR = elapsedTime * ReadKeyboardAxis(
                        kbState, Keys.Q, Keys.E) * InputTurnRate;
                    if (dR != 0) RotateClockwise(dR);
                }
            }
            public void HandleDefaultGamepadControls(GamePadState gpState, GameTime gameTime)
            {
                if (gameTime == null)
                {
                    throw new ArgumentNullException("gameTime",
                        "GameTime parameter cannot be null.");
                }

                if (gpState.IsConnected)
                {
                    float elapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

                    float dX = gpState.ThumbSticks.Right.X * elapsedTime * InputTurnRate;
                    float dY = gpState.ThumbSticks.Right.Y * elapsedTime * InputTurnRate;
                    float dR = gpState.Triggers.Right * elapsedTime * InputTurnRate;
                    dR -= gpState.Triggers.Left * elapsedTime * InputTurnRate;

                    //change orientation if necessary
                    if (dY != 0) OrbitUp(dY);
                    if (dX != 0) OrbitRight(dX);
                    if (dR != 0) RotateClockwise(dR);

                    //decrease distance to target (move forward)
                    if (gpState.Buttons.A == ButtonState.Pressed)
                    {
                        distanceValue -= elapsedTime * inputDistanceRateValue;
                    }
                    //increase distance to target (move back)
                    if (gpState.Buttons.B == ButtonState.Pressed)
                    {
                        distanceValue += elapsedTime * inputDistanceRateValue;
                    }
                    if (distanceValue < .001f) distanceValue = .001f;
                }
            }
            public void Reset()
            {
                orientation = Quaternion.CreateFromAxisAngle(Vector3.Up, MathHelper.Pi);
                distanceValue = 3f;
                targetValue = Vector3.Zero;
                yaw = MathHelper.Pi;
                pitch = 0;
            }
        }
    }
}