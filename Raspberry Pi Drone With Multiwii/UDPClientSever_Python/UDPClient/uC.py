import socket

def Main():
    host = '127.0.0.1';
    port = 5001;
    
    server = (host,5000)
    
    s = socket.socket(socket.AF_INET,socket.SOCK_DGRAM)
    s.bind((host,port))
    
    message = input("->")
    while message !='q':
        s.sendto(bytes(message,'utf_8'),server)
        data,addr = s.recvfrom(1024)
        data = bytes.decode(data,'utf-8')
        print("Receive from server \n \t" + data + ":" + str(addr))
        if(message == 'Roll'):
            for data in range(1,1000000):
                s.sendto(bytes(str(data),'utf_8'),server)
                print("---->>")

        message = input("->")
    s.close()

if __name__ == '__main__':
    Main()