import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css'; 

import Startowa from './Components/Startowa';
import WstawAutora from './Components/WstawAutora';
import ListaAutorow from './Components/ListaAutorow';
import ListaCzytelnikow from './Components/ListaCzytelnikow';
import ListaKsiazek from './Components/ListaKsiazek';
import WstawKsiazke from './Components/WstawKsiazke';
import SprawdzWypozyczenia from './Components/SprawdzWypozyczenia';

function App() {
    return (
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<Startowa />} />
                <Route path="/wstaw-autora" element={<WstawAutora />} />
                <Route path="/lista-autorow" element={<ListaAutorow />} />
                <Route path="/lista-czytelnikow" element={<ListaCzytelnikow />} />
                <Route path="/lista-ksiazek" element={<ListaKsiazek />} />
                <Route path="/wstaw-ksiazke" element={<WstawKsiazke />} />
                <Route path="/sprawdzenie-wypozyczen" element={<SprawdzWypozyczenia />} />
            </Routes>
        </BrowserRouter>
    );
}

export default App;