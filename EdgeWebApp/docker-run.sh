#! /bin/sh

docker rm -f edgewebapp 2>/dev/null
#docker create -v /data --name my-data busybox /bin/true
docker run \
        -d \
        --name edgewebapp \
        -p 443:443 \
        -p 80:80 \
        -e ASPNETCORE_HTTPS_PORT=443 \
        -e ASPNETCORE_URLS='https://+;http://+' \
        -e ASPNETCORE_Kestrel__Certificates__Default__Path='EdgeWebApp.pfx' \
        -e ASPNETCORE_Kestrel__Certificates__Default__Password='P@ssw0rd1!' \
        bellwindcontainer.azurecr.io/edgewebappmactri:0.0.19
