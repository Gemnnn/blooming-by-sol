import React from 'react';
import { Link } from 'react-router-dom';

const Header = () => {
  return (
    <header className="bg-gray-800 text-white p-4 flex justify-between items-center">
      <div className="logo">
        <Link to="/">Blooming By Sol</Link>
      </div>
      <nav className="flex space-x-4">
        <Link to="/">HOME</Link>
        <Link to="/about">ABOUT</Link>
        <Link to="/letter">LETTER</Link>
        <Link to="/candle">CANDLE</Link>
        <Link to="/faq">FAQ</Link>
        <Link to="/contact">CONTACT</Link>
      </nav>
      <div className="account flex space-x-4">
        <Link to="/account">ACCOUNT</Link>
        <input type="text" placeholder="Search" />
        <Link to="/cart">CART</Link>
      </div>
    </header>
  );
};

export default Header;