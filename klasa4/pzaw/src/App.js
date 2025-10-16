import logo from './logo.svg';
import './App.css';
import Header from './Header';
import Footer from './Footer';
import New from './New';
import Used from './Used';

function App() {
  return (
    <div className="App">
      <div className="App-body">
        <Header/>
        <table>
          <thead>
            <th>Polecamy nowe samochody w najlepszej cenie</th>
            <th>Polecamy używane samochody w najlepszej cenie</th>
          </thead>
          <tbody>
            <td>
              <New/>
            </td>
            <td>
              <Used/>
            </td>
          </tbody>
        </table>
        <Footer/>
      </div>
    </div>
  );
}

export default App;
