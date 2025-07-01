# WSL

## Overview
Windows Subsystem Linux (WSL) runs a Linux Virtual Machine in Windows. This is a requirement for Docker Desktop as it is a Linux based tool. Many other open source tools are also designed to run on Linux or Mac, so if you are using Windows then WSL is a must.

## Requirements

WSL requires a Pro version of Windows 10 or 11.

## Install
From a Terminal with elevated permissions run:
```
wsl --install
```
This will install WSL and the default Ubuntu distro.

## Run

To run WSL go into Windows Terminal and type `wsl` and hit enter.