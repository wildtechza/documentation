# Run Postgres with Helm & Helmfile

In the code base you will see the following:

📦learning_dotnet_kubernetes/
└── 📂helm/
    └── 📂charts/
        └── 🗂️dependencies/
            └── 🗂️postgressql/
                ├── 📜Chart.yaml
                ├── 📜README.md
                ├── 📜values-dev.yaml
                ├── 📜values-prod.yaml
                └── 📜values.yaml



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