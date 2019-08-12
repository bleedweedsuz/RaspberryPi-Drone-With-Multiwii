from pyMultiwii import MultiWii

class MultiWiiMain:
    
    ''' <summary>
        <para>Data Array Format</para>
        <para>0->Altitude</para>
        <para>1->Accelerometer X</para>
        <para>2->Accelerometer Y</para>
        <para>3->Accelerometer Z</para>
        <para>4->Gyroscope X</para>
        <para>5->Gyroscope Y</para>
        <para>6->Gyroscope Z</para>
        <para>7->Magnetometer X</para>
        <para>8->Magnetometer Y</para>
        <para>9->Magnetometer Z</para>
        <para>10->Motor 1</para>
        <para>11->Motor 2</para>
        <para>12->Motor 3</para>
        <para>13->Motor 4</para>
        <para>14->Roll</para>
        <para>15->Pitch</para>
        <para>16->Yaw</para>
        <para>17->Throttle</para>
        <para>18->AUX1</para>
        <para>19->AUX2</para>
        <para>20->AUX3</para>
        <para>21->AUX4</para>
        <para>22->Angle X</para>
        <para>23->Angle Y</para>
        <para>24->Heading</para>
    </summary>'''

    def __init__(self):
        #INIT MULTIWII
        self.WiiProtocol = [0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0];

        self.USBPort = "COM4";
        self.Board = MultiWii(self.USBPort)
        self.Board.arm()
        print ("ARMED")
    
    def MultiWiiWrite(self):
        #MULTIWII WRITE | SET MULTIWII VALUES
        print ("MULTIWII WRITE")
    
    def MultiWiiRead(self):
        #MULTIWII READ | READ MULTIWII DATA
        print ("M_R")
        #MultiWii READ
        self.Board.getData(MultiWii.ALTITUDE)
        #print(self.Board.attitude['angx'])
        #INIT ARRAY DATA
        self.WiiProtocol[0] = 100;'''ALTITUDE'''
        self.WiiProtocol[1] = 0;'''Accelerometer X'''
        self.WiiProtocol[2] = 0;'''Accelerometer Y'''
        self.WiiProtocol[3] = 0;'''Accelerometer Z'''
        self.WiiProtocol[4] = 0;'''Gyroscope X'''
        self.WiiProtocol[5] = 0;'''Gyroscope Y'''
        self.WiiProtocol[6] = 0;'''Gyroscope Z'''
        self.WiiProtocol[7] = 100;'''Magnetometer X'''
        self.WiiProtocol[8] = 100;'''Magnetometer Y'''
        self.WiiProtocol[9] = 5;'''Magnetometer Z'''
        self.WiiProtocol[10] = 1500;'''Motor 1'''
        self.WiiProtocol[11] = 1500;'''Motor 2'''
        self.WiiProtocol[12] = 1500;'''Motor 3'''
        self.WiiProtocol[13] = 1500;'''Motor 4'''
        self.WiiProtocol[14] = 0;'''Roll'''
        self.WiiProtocol[15] = 0;'''Pitch'''
        self.WiiProtocol[16] = 0;'''Yaw'''
        self.WiiProtocol[17] = 0;'''Throttle'''
        self.WiiProtocol[18] = 0;'''AUX1'''
        self.WiiProtocol[19] = 0;'''AUX2'''
        self.WiiProtocol[20] = 0;'''AUX3'''
        self.WiiProtocol[21] = 0;'''AUX4'''
        self.WiiProtocol[22] = 0;'''ANGLE X'''
        self.WiiProtocol[23] = 0;'''ANGLE Y'''
        self.WiiProtocol[24] = 0.2;'''HEADING'''
        messageData = "";
        for i in range(0,len(self.WiiProtocol)):
            if(i == len(self.WiiProtocol) - 1):
                messageData += str(self.WiiProtocol[i]);
            else:
                messageData += str(self.WiiProtocol[i]) + ",";
        
        return messageData;