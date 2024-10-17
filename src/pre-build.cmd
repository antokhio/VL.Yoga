IF [%1] == [] (
	SET "_PATH=.\"
) ELSE (
	SET "_PATH=%1"
)

echo %_PATH%

cmake %_PATH% -B %_PATH%YogaSharp\yoga\build
msbuild %_PATH%YogaSharp\yoga\build\yogacore.vcxproj /p:Configuration=Release /p:Platform=x64