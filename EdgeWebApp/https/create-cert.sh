openssl req -config https.config -new -out csr.pem
openssl x509 -req -days 365 -extfile https.config -extensions v3_req -in csr.pem -signkey key.pem -out EdgeWebApp.crt
openssl pkcs12 -export -out EdgeWebApp.pfx -inkey key.pem -in EdgeWebApp.crt -password pass:P@ssw0rd1!