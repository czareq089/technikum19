import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header';

const ListaAutorow = () => {
    const [autorzy, setAutorzy] = useState([]);
    const [loading, setLoading] = useState(true);
    const navigate = useNavigate();

    useEffect(() => {
        fetch('http://localhost:3100/api/autorzy')
            .then((resp) => resp.json())
            .then((json_data) => {
                setAutorzy(json_data.wynik);
                setLoading(false);
            })
            .catch((error) => {
                console.log(error);
                setLoading(false);
            });
    }, []);

    return (
        <div className="app-container">
            <Header nazwaOperacji="Autorzy naszej biblioteki:" />
            <button onClick={() => navigate('/')}>Strona startowa</button>
            <br /><br />
            
            {loading ? (
                <p className="text-white">Oczekiwanie na dane z serwera...</p>
            ) : (
                <ol className="text-white text-large">
                    {autorzy.map((autor) => (
                        <li key={autor.IDautor}>
                            {autor.imie} {autor.nazwisko}
                        </li>
                    ))}
                </ol>
            )}
        </div>
    );
};

export default ListaAutorow;