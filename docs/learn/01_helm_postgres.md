# Run Postgres with Helm & Helmfile

The Postgres helm chart will already be there, but to be able to pull it you would:

Add the bitnami repo:
```
helm repo add bitnami https://charts.bitnami.com/bitnami
```

Go into the helm folder:
```
cd helm
```

Pull Postgres
```
helm pull bitnami/postgresql --untar --version 12.1.0 -d charts/dependencies/
```

Run using the Helmfile

> **Note**  
> Make sure you have setup the shim to make it easier to call helmfile from docker, check helmfile docs.

```
./helmfile sync
```