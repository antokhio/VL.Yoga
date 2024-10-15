git apply --ignore-whitespace shared-build.patch
cd yoga
mkdir build
cd build
cmake ..
cmake --build yoga --config Debug
cmake --build yoga --config Release
cd ../..
