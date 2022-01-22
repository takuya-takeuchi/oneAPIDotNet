# Hello-Decode
  
This program is ported by C# from https://github.com/oneapi-src/oneVPL/tree/master/examples/hello/hello-decode. 
 
## How to use? 
 
## 1. Build 
 
1. Open command prompt and change to &lt;Hello-Decode_dir&gt; 
2. Type the following command 
```` 
dotnet build -c Release 
```` 
3. Make sure that **ONEAPI_ROOT** environmental variable is correct
4. Execute ***examples/oneVPL/SymlinkBinary.ps1***
 
## 3. Run 
 
The following result is example. 
 
````dos
$ cd <Hello-Decode_dir> 
$ dotnet run -c Release -- -sw -i "D:\Program Files\Intel\oneAPI\vpl\2021.2.2\examples\content\cars_128x96.h265"
Implementation details:
  ApiVersion:           2.2  
  Implementation type:  SW
  AccelerationMode via: NA
Decoding D:\Program Files\Intel\oneAPI\vpl\2021.2.2\examples\content\cars_128x96.h265 -> out.raw
Output colorspace: I420 (aka yuv420p)
Decoded 60 frames
````