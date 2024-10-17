git apply --ignore-whitespace shared-build.patch
cd yoga
cmake -B build
cd build
msbuild yoga\yogacore.vcxproj
xcopy ".\yoga\Debug\*.dll" "..\..\lib\net8.0\" /h /i /c /k /e /r /y


