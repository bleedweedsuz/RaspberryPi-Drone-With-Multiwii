using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDrone
{
    class ModelMaker
    {
        //public Field
        public bool ISMODELRUNNING = false;
        public Model model;
        public GraphicsDevice graphicDevice;
        public Vector3 modelPosition = Vector3.Zero;
        public float modelRotationX = 0.0f;
        public float modelRotationY = 0.0f;
        public float modelRotationZ = 0.0f;
        public float scale = 1f;
        //Private Field
        private float mSpeed = 0.08f;

        //Static Field
        public static float fieldOfViewAngleDegree = MathHelper.PiOver4;
        public static float nearPlaneDistance = 1.0f;
        public static float farPlaneDistance = 10000.0f;
        public ModelMaker(GraphicsDevice graphicDevice,Model model)
        {
            this.graphicDevice = graphicDevice;
            this.model = model;
        }
        public void setRotation(float x, float y, float z)
        {
            this.modelRotationX = x;
            this.modelRotationY = y;
            this.modelRotationZ = z;
        }
        public void Update(GameTime gameTime){
            if (ISMODELRUNNING) { modelRotationX += (float)gameTime.ElapsedGameTime.TotalMilliseconds * MathHelper.ToRadians(mSpeed); modelRotationY += (float)gameTime.ElapsedGameTime.TotalMilliseconds * MathHelper.ToRadians(mSpeed); modelRotationZ += (float)gameTime.ElapsedGameTime.TotalMilliseconds * MathHelper.ToRadians(mSpeed); }
            else
            {
                float tempR_X = MathHelper.ToRadians(-modelRotationX), tempR_Y = MathHelper.ToRadians(modelRotationY), tempR_Z = MathHelper.ToRadians(-modelRotationZ);
                modelRotationX = tempR_X;
                modelRotationY = tempR_Z;
                modelRotationZ = tempR_Y;// MathHelper.ToRadians(modelRotationZ);
            }
        }
        public void DrawScene(GameTime gameTime, Matrix view, Matrix projection)
        {
            
            Matrix[] transform = new Matrix[model.Bones.Count];
            model.CopyAbsoluteBoneTransformsTo(transform);
            //Fix transparency Problem
            graphicDevice.DepthStencilState = DepthStencilState.Default;
            //FIX Rasterizer
            RasterizerState rasterizerState = new RasterizerState();
            rasterizerState.CullMode = CullMode.None;
            graphicDevice.RasterizerState = rasterizerState;
            //For multiple meshes
            foreach (ModelMesh mesh in model.Meshes)
            {
                //With Effects
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.World = transform[mesh.ParentBone.Index] * Matrix.CreateRotationX(modelRotationX) * Matrix.CreateRotationY(modelRotationY) * Matrix.CreateRotationZ(modelRotationZ) * Matrix.CreateScale(scale) * Matrix.CreateTranslation(modelPosition);
                    effect.View = view;
                    effect.Projection = projection;
                }
                mesh.Draw();
            }
        }
    }
}
