import React from 'react'

import Button from './Components/button'
import Card from './Components/Card'

function App() {
  return (
    <div>
      <button>TEXT</button>
      <Button text='Multiplicação entre' n1='10.5' n2='8' />
      <Card titulo='Card React' conteudo='Card de Teste do app react' />
    </div>
  );
}

export default App;
