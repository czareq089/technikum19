import React from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header'; 

const Startowa = () => {
    const navigate = useNavigate();

    return (
        <div className="app-container">
            <Header nazwaOperacji="Strona Startowa" />
            <div className="startowa-grid">
                <div>
                    <h3>Czytelnicy</h3>
                    <button onClick={() => navigate('/lista-czytelnikow')}>Lista czytelnikow</button><br/><br/>
                    <button onClick={() => navigate('/sprawdzenie-wypozyczen')}>Sprawdzenie wypozyczen czytelnika</button>
                </div>
                <div>
                    <h3>Wstawianie danych</h3>
                    <button onClick={() => navigate('/wstaw-autora')}>Wstaw autora</button><br/><br/>
                    <button onClick={() => navigate('/wstaw-ksiazke')}>Wstaw ksiazke</button>
                </div>
                <div>
                    <h3>Sprawdzanie danych</h3>
                    <button onClick={() => navigate('/lista-autorow')}>Lista autorow</button><br/><br/>
                    <button onClick={() => navigate('/lista-ksiazek')}>Lista ksiazek</button>
                </div>
            </div>
        </div>
    );
};

export default Startowa;