#pragma once

#define PLUSLIB_API __declspec(dllexport)
#include <cstdint>

extern "C" int32_t PLUSLIB_API __stdcall sum(int32_t a, int32_t b);