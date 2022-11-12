import { BrowserRouter as Router, Routes, Route} from 'react-router-dom';
import logo from './logo.svg';
import './App.css';
import '../src/components/Users/User';
import User from '../src/components/Users/User';
import 'bootstrap/dist/css/bootstrap.min.css';
import Home from '../src/components/Home/Home';
import Item from '../src/components/Items/Item';



const App = () => {
  return (
    <div className='App'>
      <Router>
      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='/home' element={<Home />} />
        <Route path='/user' element={<User />} />
        <Route path='/item' element={<Item />} />
      </Routes>
      </Router>
    </div>
  );
}

export default App;
