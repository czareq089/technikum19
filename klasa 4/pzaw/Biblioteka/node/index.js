const mysql = require('mysql2/promise');
const express = require('express');
const cors = require('cors');

const app = express();
const PORT = 3100;

app.use(cors());
app.use(express.json());

let pool = null;

async function onBoot() {
    console.log('Server is booting...');
    try {
        pool = mysql.createPool({
            host: 'localhost',
            user: 'root',
            password: '',
            database: '4eg1',
            waitForConnections: true,
            connectionLimit: 10,
            queueLimit: 0
        });
        console.log('Connected to the MySQL database!');
    } catch (err) {
        console.error('Error:', err);
        process.exit(1);
    }
}

app.get('/api/autorzy', async (req, res) => {
    try {
        const [rows] = await pool.execute('SELECT * FROM autorzy');
        res.status(200).json({ wynik: rows });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

app.get('/api/czytelnicy', async (req, res) => {
    try {
        const [rows] = await pool.execute('SELECT * FROM `czytelnicy`');
        res.status(200).json({ wynik: rows });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

app.post('/api/wstawAutora', async (req, res) => {
    const { imie, nazwisko } = req.body;
    try {
        const odp = await pool.execute('INSERT INTO autorzy (imie, nazwisko) VALUES (?, ?)', [imie, nazwisko]);
        res.status(200).json({ warningStatus: odp[0].warningStatus });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

app.get('/api/ksiazki', async (req, res) => {
    try {
        const [rows] = await pool.execute('SELECT au.imie, au.nazwisko, ks.tytul, ks.cena, ks.IDksiazka FROM ksiazki as ks, autorzy as au where au.IDautor=ks.autor ORDER BY au.nazwisko');
        res.status(200).json({ wynik: rows });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

app.post('/api/wstawKsiazke', async (req, res) => {
    const { autorIns, tytulIns, cenaIns, dataIns } = req.body;
    try {
        const odp = await pool.execute('INSERT INTO ksiazki (autor, tytul, cena, datazakupu) VALUES (?, ?, ?, ?)', [autorIns, tytulIns, cenaIns, dataIns]);
        res.status(200).json({ warningStatus: odp[0].warningStatus });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

app.get('/api/wypozyczenia', async (req, res) => {
    const { imie, nazwisko } = req.query;
    try {
        const [rows] = await pool.execute(`
            SELECT c.czytImie, c.czytNazwisko, k.tytul 
            FROM czytelnicy c 
            JOIN wypozyczenia w ON c.IDczytelnik = w.IDczytelnik 
            JOIN ksiazki k ON w.IDksiazka = k.IDksiazka 
            WHERE c.czytImie = ? AND c.czytNazwisko = ?
        `, [imie, nazwisko]);
        res.status(200).json({ wynik: rows });
    } catch (err) {
        res.status(500).json({ error: err.message });
    }
});

onBoot().then(() => {
    app.listen(PORT, () => {
        console.log(`Server is running on http://localhost:${PORT}`);
    });
});