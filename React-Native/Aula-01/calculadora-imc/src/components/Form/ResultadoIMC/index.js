import React from 'react';
import { Text, Share, TouchableOpacity, View } from 'react-native';
import styles from './style';

const ResultadoIMC = (resultado) => {

    // Função de Compartilhamento
    const onShare = async () => {
        const result = await Share.share({
            message:
                `Seu IMC é de ${resultado.valor}`,
        });
    }

    return (
        <View style={styles.resultImc}>
            <View style={styles.boxShared}>
                <Text style={styles.informacao}>{resultado.mensagemResultado}</Text>
                <Text style={styles.nroImc}>{resultado.valorResultado}</Text>
                <TouchableOpacity
                    style={styles.botaoShared}
                    onPress={onShare}
                >
                    <Text style={styles.textShared}>Share</Text>
                </TouchableOpacity>
            </View>
        </View>
    );
}

export default ResultadoIMC;