from SuzFrameModule import SuzFrame

def Main():
    sFrame = SuzFrame("127.0.0.1",5000,True)
    while True:
        sFrame.frameMaker()
if __name__ == '__main__':
    Main()
    