#include "pch.h"
#pragma once

#ifdef PLUSLIB_EXPORTS
#define PLUSLIB_API __declspec(dllexport)
#else
#define PLUSLIB_API __declspec(dllimport)
#endif


extern "C" PLUSLIB_API long sum(
    const unsigned long long a, const unsigned long long b);