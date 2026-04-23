import React from 'react';

const Header = ({ nazwaOperacji }) => {
    const nazwaBiblioteki = "Biblioteka powiatowa w Garwolinie";

    return (
        <div className="header-container">
            <img src="/images/biblioteka.jpg" alt="Logo Biblioteki" className="header-image" />
            <h1 className="header-title">Witamy w systemie obslugi bibliotek</h1>
            <h2 className="header-subtitle-lib">Biblioteka: {nazwaBiblioteki}</h2>
            <h2 className="header-subtitle-op">{nazwaOperacji}</h2>
        </div>
    );
};

export default Header;