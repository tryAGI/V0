#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://api.v0.dev/v1/openapi.yaml
autosdk generate openapi.yaml \
  --namespace V0 \
  --clientClassName V0Client \
  --targetFramework net10.0 \
  --security-scheme Http:Header:Bearer \
  --output Generated \
  --exclude-deprecated-operations
