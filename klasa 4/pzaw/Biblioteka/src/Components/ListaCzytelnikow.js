import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header';

const ListaCzytelnikow = () => {
    const [czytelnicy, setCzytelnicy] = useState([]);
    const [loading, setLoading] = useState(true);
    const navigate = useNavigate();

    useEffect(() => {
        fetch('http://localhost:3100/api/czytelnicy')
            .then((resp) => resp.json())
            .then((json_data) => {
                setCzytelnicy(json_data.wynik);
                setLoading(false);
            })
            .catch((error) => {
                console.log(error);
                setLoading(false);
            });
    }, []);

    return (
        <div className="app-container">
            <Header nazwaOperacji="Czytelnicy" />
            <button onClick={() => navigate('/')}>Strona startowa</button>
            <br /><br />
            
            {loading ? (
                <p className="text-white text-large">Czekam na dane z serwera...</p>
            ) : (
                <ol className="text-white text-large">
                    {czytelnicy.map((czytelnik) => (
                    <li key={czytelnik.IDczytelnik}>
                    {czytelnik.czytImie} {czytelnik.czytNazwisko}
                </li>
            ))}
            </ol>
            )}
        </div>
    );
};

export default ListaCzytelnikow;