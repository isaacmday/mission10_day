import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="List of Professional Bowlers" />
      <BowlerList />
    </div>
  );
}

export default App;
