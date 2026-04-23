import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header';

const WstawAutora = () => {
    const navigate = useNavigate();
    const [imie, setImie] = useState('');
    const [nazwisko, setNazwisko] = useState('');
    const [komunikat, setKomunikat] = useState('');

    const dodajAutora = async (e) => {
        e.preventDefault();
        try {
            const response = await fetch('http://localhost:3100/api/wstawAutora', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ imie, nazwisko })
            });
            const data = await response.json();
            
            if (data.warningStatus === 0) {
                setKomunikat(`Autor: ${imie} ${nazwisko} został wstawiony do bazy danych.`);
            } else {
                setKomunikat('Wystąpił problem podczas wstawiania danych.');
            }
        } catch (error) {
            setKomunikat('Błąd połączenia z serwerem.');
        }
    };

    return (
        <div className="app-container">
            <Header nazwaOperacji="Wstawianie autora" />
            <button onClick={() => navigate('/')}>Strona startowa</button>
            <br /><br />

            {komunikat ? (
                <p className="text-white text-large">{komunikat}</p>
            ) : (
                <form onSubmit={dodajAutora} className="text-white">
                    <label>Imie: 
                        <input type="text" value={imie} onChange={(e) => setImie(e.target.value)} required />
                    </label><br/><br/>
                    <label>Nazwisko: 
                        <input type="text" value={nazwisko} onChange={(e) => setNazwisko(e.target.value)} required />
                    </label><br/><br/>
                    <button type="submit">Wstaw</button>
                </form>
            )}
        </div>
    );
};

export default WstawAutora;