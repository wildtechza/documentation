# Helm and Helmfile

## Pull Helm Charts

Add Repo
```
helm repo add runix https://helm.runix.net
```

Pull
```
helm pull runix/pgadmin4 --untar --untardir charts/dependencies
```

## Apply Helmfile

```
./helmfile apply
```