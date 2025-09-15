@Echo off

Set Test Result in Console

Call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\Tools\VsDevCmd.bat"

VSTest.Console.Exe F:\Practice_Final\SeleniumWithC#_GitHub\TestPro2_ComplexFramwork\TestPro2_ComplexFramwork\bin\Debug\netcoreapp3.1\TestPro2_ComplexFramwork.dll

Pause