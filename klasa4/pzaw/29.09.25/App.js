import './App.css';
import szescian from './bryly/szescian.png';
import prostopadloscian from './bryly/prostopadloscian.png';
import kula from './bryly/kula.png'

function obliczPole(bryla){
  switch (bryla){
  case bryla = "SZESCIAN":
    let w1 = prompt("Podaj wymiar sześcianu");
    return w1 * w1 * w1;
  case bryla = "PROSTOPADLOSCIAN":
    let wp1 = prompt("Podaj wymiar 1 prostopadłościanu");
    let wp2 = prompt("Podaj wymiar 2 prostopadłościanu");
    let wp3 = prompt("Podaj wymiar 3 prostopadłościanu");
    return 2*wp1*wp2+2*wp1*wp3+2*wp2*wp3
  case bryla = "KULA":
    let r = prompt("Podaj promień kuli");
    return 4*Math.PI*(r*r);
  }
}

const bryly = [
  {"nazwa" : "SZESCIAN", "ilustracja" : szescian, "wzory" : "objetosc: V = a^3 \n pole: P=6a^2", "przyklad" : <p><p className='wymiar'>1. wymiar: 2</p><p className='wynik'>POLE: 24</p><p className='wynik'>OBJETOSC: 8</p></p>},
  {"nazwa" : "PROSTOPADLOSCIAN", "ilustracja" : prostopadloscian, "wzory" : "objetosc: V = a*b*h \n pole: P=2*a*b+2*a*h+2*b*h"},
  {"nazwa" : "KULA", "ilustracja" : kula, "wzory" : "objetosc: V = 4/3*pi*r^3 \n pole: P=4*pi*r^2"}
];

function App() {
  return (
    <div className="App">
      <h1>Bryly</h1>
      <table cellpadding="0" cellspacing="0">
        <thead>
          <tr>
            <th>BRYLA</th>
            <th>ILUSTRACJA</th>
            <th>WZORY</th>
            <th>PRZYKLAD</th>
          </tr>
        </thead>
        <tbody>
          {bryly.map((item,index)=>(
          <tr key ={item.id}>
            <td><b><i>{bryly[index].nazwa}</i></b></td>
            <td><img src={bryly[index].ilustracja} alt={bryly[index].nazwa} /></td>
            <td>{bryly[index].wzory}</td>
            <td>
              {obliczPole(bryly[index].nazwa)}
            </td>
          </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
