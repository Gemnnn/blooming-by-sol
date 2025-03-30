import React from 'react';
import { useState } from 'react'

const MainContent = () => {
    const [count, setCount] = useState(0)
    return (
        <main className="main-content">
        <p>This is the main content of the homepage.</p>
        <button onClick={() => setCount((count) => count + 1)}>
            count is {count}
        </button>
        </main>
  );
};

export default MainContent;