#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.v0.dev/v1/openapi.yaml
autosdk generate openapi.yaml \
  --namespace V0 \
  --clientClassName V0Client \
  --targetFramework net10.0 \
  --security-scheme Http:Header:Bearer \
  --output Generated \
  --exclude-deprecated-operations
