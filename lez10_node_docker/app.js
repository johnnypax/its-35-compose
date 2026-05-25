const express = require('express');

const app = express();

const PORT = 3000;
const HOST = "127.0.0.1";

app.listen(PORT, () => {
    console.log("Sono in ascolto all'indirizzo: " + HOST + ":" + PORT);
});

let lista = [
    {
        id: 1,
        nome: "Mario",
        cognome: "Rossi"
    },
    {
        id: 2,
        nome: "Luca",
        cognome: "Verdi"
    },
]

app.get("/", (req, res) => {
    res.json(lista);
});
    