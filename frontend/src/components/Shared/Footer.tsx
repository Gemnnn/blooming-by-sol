import React from 'react';

const Footer = () => {
  return (
    <footer className="bg-gray-800 text-white p-4 mt-8">
      <div className="flex justify-between">
        <div>
          <h1>Blooming By Sol</h1>
          <p>Love</p>
          <p>Instagram</p>
        </div>
        <div>
          <h2>Quick Link</h2>
          <ul>
            <li><a href="/">HOME</a></li>
            <li><a href="/about">ABOUT</a></li>
            <li><a href="/letter">LETTER</a></li>
            <li><a href="/candle">CANDLE</a></li>
            <li><a href="/faq">FAQ</a></li>
            <li><a href="/contact">CONTACT</a></li>
          </ul>
        </div>
      </div>
    </footer>
  );
};

export default Footer;