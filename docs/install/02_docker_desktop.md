# Docker Desktop

## Overview

### Docker
Docker is a tool that can create and run containers. Containers are lightweight environments that package applications. We will run everything we need as containers. For example databases, web sites, APIs, even our own code we write will run as containers. This is beneficial as you can easily run them anywhere without manually installing them as was the "old" way.

### Kubernetes
Kubernetes is a container orchestrator, it runs containers like Docker but has many more advanced tools, scalability, etc. We will work with it in Docker for ease of use and it will be similar to how you will do things in Production.

## Requirements

- Virtualization Enabled
- Windows Subsystem Linux (WSL)

## Install

> **📝 Note:** Install in Windows

https://www.docker.com/products/docker-desktop/


## Configure
Run Docker Desktop. 

### Configure Docker Desktop for WSL 2 Integration
- Open Docker Desktop settings (Settings > Resources > WSL Integration)
- Enable integration with your installed WSL distros (e.g., Ubuntu)
- Apply & restart Docker

### Enable Kubernetes
- Open Docker Desktop settings (Settings > Kubernetes)
- Enable Kubernetes
- Kubeadm
- Apply & restart Docker