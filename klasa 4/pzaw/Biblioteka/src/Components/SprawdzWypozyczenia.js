import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header';

const SprawdzWypozyczenia = () => {
    const navigate = useNavigate();
    const [imie, setImie] = useState('');
    const [nazwisko, setNazwisko] = useState('');
    const [wypozyczenia, setWypozyczenia] = useState([]);
    const [szukano, setSzukano] = useState(false);

    const szukaj = async (e) => {
        e.preventDefault();
        try {
            const url = `http://localhost:3100/api/wypozyczenia?imie=${imie}&nazwisko=${nazwisko}`;
            const response = await fetch(url);
            const data = await response.json();
            setWypozyczenia(data.wynik);
            setSzukano(true);
        } catch (error) {
            console.error("Błąd", error);
        }
    };

    return (
        <div className="app-container text-white">
            <Header nazwaOperacji="Wypozyczenia" />
            <button onClick={() => navigate('/')}>Strona startowa</button>
            <br /><br />

            <form onSubmit={szukaj}>
                <label>Imie: <input type="text" value={imie} onChange={(e) => setImie(e.target.value)} required /></label><br/><br/>
                <label>Nazwisko: <input type="text" value={nazwisko} onChange={(e) => setNazwisko(e.target.value)} required /></label><br/><br/>
                <button type="submit">Szukaj</button>
            </form>
            <br/><br/>

            {szukano && wypozyczenia.length > 0 && (
                <table border="1" cellPadding="5" style={{borderCollapse: "collapse"}}>
                    <thead>
                        <tr><th>Imie</th><th>Nazwisko</th><th>Tytul</th></tr>
                    </thead>
                    <tbody>
                        {wypozyczenia.map((w, index) => (
                            <tr key={index}><td>{w.czytImie}</td><td>{w.czytNazwisko}</td><td>{w.tytul}</td></tr>
                        ))}
                    </tbody>
                </table>
            )}
            {szukano && wypozyczenia.length === 0 && (
                <p>Czytelnik nie ma wypozyczonych ksiazek lub nie ma go w bazie.</p>
            )}
        </div>
    );
};

export default SprawdzWypozyczenia;