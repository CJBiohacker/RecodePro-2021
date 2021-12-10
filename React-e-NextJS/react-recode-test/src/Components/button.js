import React from 'react'

const Button = (props) => {

    const { text, n1, n2 } = props
    const calc = n1 * n2;

    return (
        <div>
            <button>{text} {n1} e {n2} = {calc}</button>
        </div>
    )
}

export default Button