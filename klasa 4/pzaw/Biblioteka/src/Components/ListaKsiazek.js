import React, { useEffect, useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Header from './Header';

const ListaKsiazek = () => {
    const [ksiazki, setKsiazki] = useState([]);
    const [loading, setLoading] = useState(true);
    const navigate = useNavigate();

    useEffect(() => {
        fetch('http://localhost:3100/api/ksiazki')
            .then((resp) => resp.json())
            .then((json_data) => {
                setKsiazki(json_data.wynik);
                setLoading(false);
            })
            .catch((error) => console.log(error));
    }, []);

    return (
        <div className="app-container">
            <Header nazwaOperacji="Ksiazki w naszej bibliotece:" />
            <button onClick={() => navigate('/')}>Strona startowa</button>
            <br /><br />
            
            {loading ? (
                <p className="text-white text-large">Czekam na dane z serwera...</p>
            ) : (
                <table className="text-white text-large" border="1" cellPadding="5" style={{borderCollapse: "collapse"}}>
                    <thead>
                        <tr>
                            <th>Imie</th>
                            <th>Nazwisko</th>
                            <th>Tytul</th>
                            <th>Cena</th>
                        </tr>
                    </thead>
                    <tbody>
                        {ksiazki.map((ksiazka) => (
                            <tr key={ksiazka.IDksiazka}>
                                <td>{ksiazka.imie}</td>
                                <td>{ksiazka.nazwisko}</td>
                                <td>{ksiazka.tytul}</td>
                                <td>{ksiazka.cena}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            )}
        </div>
    );
};

export default ListaKsiazek;