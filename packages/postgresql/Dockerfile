# Build stage
FROM postgres:14-alpine as dumper

# Add initial data to database
# COPY psql_dump.sql /docker-entrypoint-initdb.d/

#We need to execute this sed command in order to remove the exec "$@" content that exists in the docker-entrypoint.sh file so it will not start the PostgreSQL daemon (we don’t need it on this step).
RUN ["sed", "-i", "s/exec \"$@\"/echo \"skipping...\"/", "/usr/local/bin/docker-entrypoint.sh"]

ENV POSTGRES_USER=postgres
ENV POSTGRES_PASSWORD=secret
ENV POSTGRES_DB hireguide
ENV PGDATA=/data

# Execute the entrypoint itself. It will execute the dump and load the data into /data folder. Since we executed the sed command to remove the $@ content it will not run the PostgreSQL daemon
RUN ["/usr/local/bin/docker-entrypoint.sh", "postgres"]

# Run stage
FROM postgres:14-alpine

COPY --from=dumper /data $PGDATA