echo %1 %2 %3 %4
echo %1bin\%2\%3\%4*.dll

xcopy %1bin\%2\%3\%4\\*.dll %1..\..\lib\%2\%4 /h /i /c /k /e /r /y
xcopy %1..\YogaSharp\yoga\build\Release\*.dll %1..\..\runtimes\win-x64\native /h /i /c /k /e /r /y