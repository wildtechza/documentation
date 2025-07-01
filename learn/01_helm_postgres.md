# Run Postgres with Helm

Add Postgres:
helm repo add bitnami https://charts.bitnami.com/bitnami
helm pull bitnami/postgresql --untar --version 12.1.0 -d charts/dependencies/
