#!/usr/bin/env bash
export EnableNuGetPackageRestore="true"
msbuild Build/Build.proj /p:Configuration="Mono Release" /t:GoMono
