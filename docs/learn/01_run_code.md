# Run Code

In the code base you will see the following:
```
📦learning_dotnet_kubernetes/
└── 📂helm/
    ├── 📜helmfile
    └── 📜helmfile.yaml
```

Go into the helm folder and run:
```
./helmfile apply
```

This should run all the code. If cannot run it or get and error you may need to give permissions and try again with:
```
chmod +x helmfile
```

When you have already applied the helmfile and want to sync any changes:
```
./helmfile sync
```