#!/bin/bash
rerun -n "Test Watcher" -d Demo -d Demo.Tests/ -p "**/*.fs" -- dotnet test

