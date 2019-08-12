import socket
import string
import random
from random import randint
import MultiWiiMainModule

class SuzFrame:
    
    '''SuzFrame Protocol'''
    def __init__(self,host,port,_log,_sizeOfPL =8):
        self.ClientMessage = ""
        self._socket = socket.socket(socket.AF_INET,socket.SOCK_DGRAM)
        self._socket.bind((host,port))
        self._log = _log
        self._sizeOfPL = _sizeOfPL
        #LOG
        if(self._log):
            print("SOCKET INIT:" + host + ":" ,port)
               
        #MULTIWII MODULE
        self.multiWiiMain = MultiWiiMainModule.MultiWiiMain()
    
    def frameMaker(self):
        self.readFrame()
        #READ THE FRAME MODULE DATA
        self.writeFrame(self.multiWiiMain.MultiWiiRead())
        
    def readFrame(self):
        '''Read Frame'''
        '''#Frame 0'''
        sizeOfPL = self._sizeOfPL
        sizeOfPLData, addr = self._socket.recvfrom(sizeOfPL)
        sizeOfPLData = bytes.decode(sizeOfPLData,'utf-8')
        '''DeCompress Data'''
        #sizeOfPLData = CompDecomp.Decompress(self,sizeOfPLData)
        
        '''GetFrame Address'''
        self.fromAddress = addr
        
        '''set FrameType'''
        FrameType = sizeOfPLData[0]
        if(FrameType != '0'):
            print('ERROR FRAME',FrameType)
            return
        sizeOfPLData = int(sizeOfPLData) #IMP
        #LOG
        if(self._log):
            print("1->Size:",sizeOfPLData,"Addr:",addr,"Frame:",FrameType)
        
        '''#Frame 1'''
        sizeOfPL = sizeOfPLData
        MainPayLoad, addr = self._socket.recvfrom(sizeOfPL)
        MainPayLoad = bytes.decode(MainPayLoad,'utf-8') #IMP
        FrameType = MainPayLoad[0]
        if(FrameType != '1'):
            print('ERROR FRAME',FrameType)
            return
        
        MainPayLoad = self.repackPayLoad(MainPayLoad)
        self.ClientMessage = MainPayLoad #SET THE MAIN PAYLOAD DATA
        
        #LOG
        if(self._log):
            print("2->Data:",MainPayLoad,"Addr:",addr,"Frame:",FrameType)
    
    def writeFrame(self,frameMessage):
        if(self.fromAddress is None):
            if(self._log):
                print("No FromAddress")
            return
        
        '''Write Frame'''
        '''#Frame 0'''
        MainPayLoad = "1" + frameMessage
        
        '''COMPRESS MAIN PAYLOAD'''
        #MainPayLoad = zlib.compress(bytes(MainPayLoad,'utf-8'), 5) #WITH COMPRESS
        
        MainPayLoad = bytes(MainPayLoad,'utf-8') #WITHOUT COMPRESS
        
        sizeOfPL =  "0" + str(len(MainPayLoad))
        self._socket.sendto(bytes(sizeOfPL,'utf-8'),self.fromAddress)
        '''#Frame 1'''
        
        #SEND MAIN PAYLOAD
        self._socket.sendto(MainPayLoad,self.fromAddress)
        #LOG
        if(self._log):
            print("DataSize:",sizeOfPL)
    
    def repackPayLoad(self,data):
        return data[1:len(data)]
    
    def RandomData(self,size =6,chars = string.ascii_letters + string.digits):
        return ''.join(random.choice(chars) for _ in range(size))       
    