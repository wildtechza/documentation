# Helmfile

## Overview

Helmfile allows us to easily run/apply multiple helm files as well as other useful features.

## Install

Run wsl and follow the Linux install commands here:

https://helmfile.readthedocs.io/en/latest/#running-as-a-container

Run:
```
docker run --rm --net=host -v "${HOME}/.kube:/helm/.kube" -v "${HOME}/.config/helm:/helm/.config/helm" -v "${PWD}:/wd" --workdir /wd ghcr.io/helmfile/helmfile:v0.156.0 helmfile sync
```

Add shim:
```
printf '%s\n' '#!/bin/sh' 'docker run --rm --net=host -v "${HOME}/.kube:/helm/.kube" -v "${HOME}/.config/helm:/helm/.config/helm" -v "${PWD}:/wd" --workdir /wd ghcr.io/helmfile/helmfile:v0.156.0 helmfile "$@"' | tee helmfile

chmod +x helmfile

./helmfile sync
```