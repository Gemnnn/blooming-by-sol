import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import './styles/App.css';
import HomePage from './features/Home/pages/HomePage';
import Header from './components/Shared/Header';
import Footer from './components/Shared/Footer';

function App() {
  return (
    <Router>
      <Header />
      <main>
        <Routes>
          <Route path="/" element={<HomePage />} />
          {/* more page */}
        </Routes>
      </main>
      <Footer />
    </Router>
  );
}

export default App;