import React from 'react'

import '../Styles/Card.css'

const Card = (props) => {

    let { titulo, conteudo } = props;

    return (
        <div id='align-container'>
            <div className='container'>
                <h1>{titulo}</h1>
                <p>{conteudo}</p>
            </div>
        </div>
    )

}

export default Card