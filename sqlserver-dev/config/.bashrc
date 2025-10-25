if [ -f ~/.bashrc ]; then
    source ~/.bashrc
fi
echo "✅ Bashrc cargado automáticamente"

alias ll='ls -la'

server() {
  echo "Conectando al servidor SQL..."
  /opt/mssql-tools18/bin/sqlcmd -S localhost -U SA -P "$SA_PASSWORD" -C -y 30 -Y 30 "$@"
}
