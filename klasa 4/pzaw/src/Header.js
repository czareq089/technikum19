function Header(){
    let nazwa_firmy = "Idealny Samochod";
    let logo = "";
    return(
        <div className="Header">
                    <h1>Witamy an stronie firmy: {nazwa_firmy}</h1>
                    <img src={logo} alt="logo" className="Logo"></img>
        </div>
    );
}

export default Header;