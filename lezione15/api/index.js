const express = require('express');

const PORT = 8080;
const HOST = '0.0.0.0';

const app = express();
app.get('/', (request, response) => {
    console.log('Nuova richiesta');
    response.send('Ciao da Express');
});

app.listen(PORT,HOST);
console.log('API In esecuzione');