RESTORE DATABASE eApartman FROM DISK='eApartman.bak' 
WITH MOVE 'Apartmani' TO '/var/opt/mssql/data/eApartman.mdf', 
MOVE 'Apartmani_log' TO '/var/opt/mssql/data/Apartmani_log.ldf'