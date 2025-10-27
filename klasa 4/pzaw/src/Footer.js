function Footer(){
    let godzina_otwarcia;
    let godzina_zamkniecia;
    return(
        <div className="Footer">
            <p>Zapraszamy codziennie od {godzina_otwarcia} do {godzina_zamkniecia}</p>
        </div>
    );
}

export default Footer;