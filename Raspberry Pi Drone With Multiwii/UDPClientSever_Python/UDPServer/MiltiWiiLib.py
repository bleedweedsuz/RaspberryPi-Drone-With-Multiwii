'''
Created on Oct 12, 2016
@author: Sujan Thapa
'''
import serial
import time
import struct

class MultiWiiLib:
    '''FOR MORE INFO http://www.multiwii.com/wiki/index.php?title=Multiwii_Serial_Protocol'''
    MSP_IDENT = 100
    MSP_STATUS = 101
    MSP_RAW_IMU = 102
    MSP_SERVO = 103
    MSP_MOTOR = 104
    MSP_SET_MOTOR = 214
    MSP_RC = 105
    MSP_SET_RAW_RC =200
    MSP_RAW_GPS = 106
    MSP_SET_RAW_GPS = 201
    MSP_COMP_GPS = 107
    MSP_ATTITUDE = 108
    MSP_ALTITUDE = 109
    MSP_ANALOG = 110
    MSP_RC_TUNING = 111
    MSP_SET_RC_TUNING = 204
    MSP_PID = 112
    MSP_SET_PID = 202
    MSP_BOX = 113
    MSP_SET_BOX = 203
    MSP_MISC = 114
    MSP_SET_MISC = 207
    MSP_MOTOR_PINS = 115
    MSP_BOXNAMES = 116
    MSP_PIDNAMES = 117
    MSP_WP = 118
    MSP_SET_WP = 209
    MSP_BOXIDS = 119
    MSP_SERVO_CONF = 120
    MSP_SET_SERVO_CONF = 212
    MSP_ACC_CALIBRATION = 205
    MSP_MAG_CALIBRATION = 206
    MSP_RESET_CONF = 208 
    MSP_SELECT_SETTING = 210 #** switch rc serial
    MSP_SET_HEAD = 211 #** is serial
    
    def __init__(self, serialPort):
        #Main variables for channels, IMU, motor, attitude
        self.RC_CHANNELS = {'ROLL':0, 'PITCH':0, 'YAW':0, 'THROTTLE':0}
        self.RAW_IMU = {'AX':0, 'AY':0, 'AZ':0, 'GX':0,'GY':0,'GZ':0}
        self.MOTOR = {'M1':0, 'M2':0, 'M3':0, 'M4':0}
        self.ATTITUDE = {'ANGLE_X':0, 'ANGLE_Y':0, 'HEADING':0}