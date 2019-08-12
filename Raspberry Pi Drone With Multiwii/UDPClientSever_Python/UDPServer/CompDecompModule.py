import zlib

class CompDecomp:
    level = 5
    def Decompress(self,_compressData):
        '''DE-Compress Data'''
        decompressdata = zlib.decompress(_compressData, wbits, bufsize)
        return decompressdata
        
    def Compress(self,_decompressData):
        '''Compress Data'''
        compressData = zlib.compress(bytes(_decompressData,'utf-8'), self.level)
        return compressData