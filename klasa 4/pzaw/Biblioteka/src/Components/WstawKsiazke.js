import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header';

const WstawKsiazke = () => {
    const navigate = useNavigate();
    const [autorzy, setAutorzy] = useState([]);
    const [autorIns, setAutorIns] = useState('');
    const [tytulIns, setTytulIns] = useState('');
    const [cenaIns, setCenaIns] = useState('');
    const [dataIns, setDataIns] = useState('');
    const [komunikat, setKomunikat] = useState(null);

    useEffect(() => {
        fetch('http://localhost:3100/api/autorzy')
            .then(res => res.json())
            .then(data => {
                setAutorzy(data.wynik);
                if(data.wynik.length > 0) setAutorIns(data.wynik[0].IDautor);
            });
    }, []);

    const dodajKsiazke = async (e) => {
        e.preventDefault();
        try {
            const response = await fetch('http://localhost:3100/api/wstawKsiazke', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ autorIns, tytulIns, cenaIns, dataIns })
            });
            const data = await response.json();
            
            if (data.warningStatus === 0) {
                const wybranyAutor = autorzy.find(a => a.IDautor === parseInt(autorIns));
                setKomunikat(`Ksiazka: autor: ${wybranyAutor.imie} ${wybranyAutor.nazwisko}, tytul: ${tytulIns}, cena: ${cenaIns}, data zakupu: ${dataIns} zostala dodana do bazy danych.`);
            }
        } catch (error) {
            console.error("Błąd", error);
        }
    };

    return (
        <div className="app-container text-white">
            <Header nazwaOperacji="Wstawianie ksiazek" />
            <button onClick={() => navigate('/')}>Strona startowa</button>
            <br /><br />

            {komunikat ? (
                <p className="text-large">{komunikat}</p>
            ) : (
                <form onSubmit={dodajKsiazke}>
                    <label>Prosze wybrac autora: 
                        <select value={autorIns} onChange={(e) => setAutorIns(e.target.value)}>
                            {autorzy.map(a => (
                                <option key={a.IDautor} value={a.IDautor}>{a.imie} {a.nazwisko}</option>
                            ))}
                        </select>
                    </label><br/><br/>
                    <label>Tytul: <input type="text" value={tytulIns} onChange={(e) => setTytulIns(e.target.value)} required /></label><br/><br/>
                    <label>Cena: <input type="number" value={cenaIns} onChange={(e) => setCenaIns(e.target.value)} required /></label><br/><br/>
                    <label>Data zakupu: <input type="date" value={dataIns} onChange={(e) => setDataIns(e.target.value)} required /></label><br/><br/>
                    <button type="submit">Wstaw ksiazke</button>
                </form>
            )}
        </div>
    );
};

export default WstawKsiazke;