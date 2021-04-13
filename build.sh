#!/usr/bin/env bash

shopt -s globstar
mcs -out:main.exe -- **/*.cs

a="1 2 3"
echo "$a"
