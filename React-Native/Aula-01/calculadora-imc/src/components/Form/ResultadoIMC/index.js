import React from 'react';
import { Text, View } from 'react-native';

const ResultadoIMC = (resultado) => {
    return (
        <View>
            <Text >{resultado.mensagem}</Text>
            <Text >{resultado.valor}</Text>
        </View>
    );
}

export default ResultadoIMC;