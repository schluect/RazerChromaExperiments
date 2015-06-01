@echo off
copy "C:\Users\Chris\Documents\Visual Studio 2013\Projects\ChromaGraphics\ChromaGraphics\bin\Release\ChromaGraphics.dll" "lib\ChromaGraphics.dll"
nuget pack "ChromaGraphics.dll.nuspec"

set /p aver="Enter Version Number (0 for exit): "

if not %aver% == 0 (
	nuget push ChromaGraphics.%aver%.nupkg
	pause
)