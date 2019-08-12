using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDrone
{
    class Utils
    {
        /// <summary>
        /// Mapped In value > Out Value
        /// </summary>
        /// <param name="x">Main Value</param>
        /// <param name="in_min">Min In Value</param>
        /// <param name="in_max">Max In Value</param>
        /// <param name="out_min">Min Out Value</param>
        /// <param name="out_max">Max Out Value</param>
        /// <returns>Map Data</returns>
        public static long map(int x, long in_min, long in_max, long out_min, long out_max)
        {
            return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
        }
        /// <summary>
        ///<para>Data Array Format [MIN 25 Array Data]</para>
        ///<para>0->Altitude</para>
        ///<para>1->Accelerometer X</para>
        ///<para>2->Accelerometer Y</para>
        ///<para>3->Accelerometer Z</para>
        ///<para>4->Gyroscope X</para>
        ///<para>5->Gyroscope Y</para>
        ///<para>6->Gyroscope Z</para>
        ///<para>7->Magnetometer X</para>
        ///<para>8->Magnetometer Y</para>
        ///<para>9->Magnetometer Z</para>
        ///<para>10->Motor 1</para>
        ///<para>11->Motor 2</para>
        ///<para>12->Motor 3</para>
        ///<para>13->Motor 4</para>
        ///<para>14->Roll</para>
        ///<para>15->Pitch</para>
        ///<para>16->Yaw</para>
        ///<para>17->Throttle</para>
        ///<para>18->AUX1</para>
        ///<para>19->AUX2</para>
        ///<para>20->AUX3</para>
        ///<para>21->AUX4</para>
        ///<para>22->Angle X</para>
        ///<para>23->Angle Y</para>
        ///<para>24->Heading</para>
        ///</summary>
        public static int MWII_ANGLEX = 0, MWII_ANGLEY = 1, MWII_HEADING = 2, MWII_ALTITUDE= 3;
        public static float[] MapAckMulWiiBoard(String AckMessage)
        {
            int MAX =4;
            float[] data = new float[MAX];
            if (AckMessage.Length > 0)
            {
                string[] tempData = AckMessage.Split(',');
                for (int i = 0; i < tempData.Length; i++)
                {
                    data[i] = float.Parse(tempData[i]);
                }
            }
            else
            {
                data = new float[] {0,0,0,0};
            }
            return data;
        }
        /// <summary>
        /// Convert Object array to string format
        /// </summary>
        /// <param name="floatArray">Used as a instance object array</param>
        /// <returns></returns>
        public static String ConvertFloatArrayToStringFormat(float[] floatArray)
        {
            if (floatArray.Length <= 0) { return "[ ]"; }
            String data = "[ ";
            for (int i = 0; i < floatArray.Length; i++)
            {
                data += floatArray[i] +  " ";
            }
            data += "]";
            return data;
        }
        public static void RBOX_AppendText(System.Windows.Forms.RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
