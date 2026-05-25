#!/bin/bash

# Avvia SQL Server in background
/opt/mssql/bin/sqlservr &

# Attende che SQL Server sia pronto
echo "Attendo l'avvio di SQL Server..."

sleep 20

# Esegue lo script di inizializzazione
echo "Eseguo init.sql..."

 /opt/mssql-tools18/bin/sqlcmd \
  -S localhost \
  -U sa \
  -P "$MSSQL_SA_PASSWORD" \
  -C \
  -i /app/database_import.sql

echo "Database inizializzato."

# Mantiene il container attivo
wait